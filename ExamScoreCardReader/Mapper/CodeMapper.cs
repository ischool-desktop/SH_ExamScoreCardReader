using System;
using System.Collections.Generic;
using System.Text;

namespace SH_ExamScoreCardReader.Mapper
{
    internal abstract class CodeMapper
    {
        protected Dictionary<string, string> CodeMap;

        public CodeMapper()
        {
            CodeMap = new Dictionary<string, string>();
            LoadCodes();
        }

        protected virtual void LoadCodes()
        {
            CodeMap.Clear();
        }

        public void Reload()
        {
            LoadCodes();
        }

        public bool CheckCodeExists(string code)
        {
            return (CodeMap.ContainsKey(code));
        }

        public string Map(string code)
        {
            string c = code.Trim();

            if (CodeMap.ContainsKey(c))
                return CodeMap[c];
            else
                return string.Empty;
        }
    }
}
