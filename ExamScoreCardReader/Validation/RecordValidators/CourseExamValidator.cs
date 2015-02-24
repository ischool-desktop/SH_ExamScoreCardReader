using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SH_ExamScoreCardReader.Model;
using SHSchool.Data;

namespace SH_ExamScoreCardReader.Validation.RecordValidators
{
    internal class CourseExamValidator : IRecordValidator<DataRecord>
    {
        private StudentCourseInfo _studentCourseInfo;
        private Dictionary<string, List<string>> _aeTable;

        public CourseExamValidator(StudentCourseInfo studentCourseInfo, List<SHAEIncludeRecord> aeList, List<SHExamRecord> examList)
        {
            _studentCourseInfo = studentCourseInfo;
            _aeTable = new Dictionary<string, List<string>>();

            Dictionary<string, string> examNames = new Dictionary<string, string>();
            foreach (SHExamRecord exam in examList)
            {
                if (!examNames.ContainsKey(exam.ID))
                    examNames.Add(exam.ID, exam.Name);
            }

            foreach (SHAEIncludeRecord ae in aeList)
            {
                if (!_aeTable.ContainsKey(ae.RefAssessmentSetupID))
                    _aeTable.Add(ae.RefAssessmentSetupID, new List<string>());
                if (examNames.ContainsKey(ae.RefExamID))
                    _aeTable[ae.RefAssessmentSetupID].Add(examNames[ae.RefExamID]);
            }
        }

        #region IRecordValidator<DataRecord> 成員

        public string Validate(DataRecord record)
        {
            List<SHCourseRecord> courses = new List<SHCourseRecord>();
            foreach (SHCourseRecord course in _studentCourseInfo.GetCourses(record.StudentNumber))
            {
                if (record.Subjects.Contains(course.Subject))
                    courses.Add(course);
            }
            StringBuilder builder = new StringBuilder("");
            foreach (SHCourseRecord course in courses)
            {
                if (string.IsNullOrEmpty(course.RefAssessmentSetupID))
                    builder.AppendLine(string.Format("課程「{0}」沒有評量設定。", course.Name));
                else if (!_aeTable.ContainsKey(course.RefAssessmentSetupID))
                    builder.AppendLine(string.Format("課程「{0}」評量設定有誤。", course.Name));
                else
                {
                    bool found = false;
                    foreach (string examName in _aeTable[course.RefAssessmentSetupID])
                    {
                        if (examName == record.Exam)
                        {
                            found = true;
                            break;
                        }
                    }
                    if(!found)
                        builder.AppendLine(string.Format("課程「{0}」沒有試別「{1}」。", course.Name, record.Exam));
                }
            }
            return builder.ToString();
        }

        #endregion
    }
}
