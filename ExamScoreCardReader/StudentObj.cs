using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SH_ExamScoreCardReader
{
    class StudentObj
    {
        public StudentObj(DataRow row)
        {
            StudentID = "" + row["id"];
            StudentNumber = "" + row["student_number"];
        }

        public string StudentID { get; set; }

        public string StudentNumber { get; set; }


    }
}
