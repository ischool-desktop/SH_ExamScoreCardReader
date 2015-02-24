using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SH_ExamScoreCardReader.Mapper;
using SH_ExamScoreCardReader.Model;

namespace SH_ExamScoreCardReader.Validation.RecordValidators
{
    internal class ExamCodeValidator : IRecordValidator<RawData>
    {
        #region IRecordValidator<RawData> 成員
        public string Validate(RawData record)
        {
            if (ExamCodeMapper.Instance.CheckCodeExists(record.ExamCode))
                return string.Empty;
            else
                return string.Format("試別代碼「{0}」不存在。", record.ExamCode);
        }
        #endregion
    }
}
