using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SH_ExamScoreCardReader
{
    interface IColumnValidator
    {
        bool IsValid(string input);
        string GetErrorMessage();
    }
}
