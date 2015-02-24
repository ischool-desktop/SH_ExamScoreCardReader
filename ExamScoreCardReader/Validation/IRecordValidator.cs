using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SH_ExamScoreCardReader.Validation
{
    internal interface IRecordValidator<T>
    {
        string Validate(T record);
    }
}
