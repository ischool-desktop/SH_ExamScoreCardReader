using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SH_ExamScoreCardReader.Model;
using SHSchool.Data;

namespace SH_ExamScoreCardReader.Validation.RecordValidators
{
    internal class ExamValidator : IRecordValidator<DataRecord>
    {
        private List<string> _examNameList;
        public ExamValidator(List<SHExamRecord> examList)
        {
            _examNameList = new List<string>();
            foreach (SHExamRecord exam in examList)
            {
                if (!_examNameList.Contains(exam.Name))
                    _examNameList.Add(exam.Name);
            }
        }

        #region IRecordValidator<DataRecord> 成員

        public string Validate(DataRecord record)
        {
            if (!_examNameList.Contains(record.Exam))
                return string.Format("試別「{0}」不存在系統中。", record.Exam);
            else
                return string.Empty;
        }

        #endregion
    }
}
