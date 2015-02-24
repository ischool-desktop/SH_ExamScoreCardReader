using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SH_ExamScoreCardReader
{
    class Permissions
    {
        public static string 匯入讀卡成績 { get { return "SHEvaluation.Course.ReaderScoreImport01"; } }

        public static bool 匯入讀卡成績權限
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[匯入讀卡成績].Executable;
            }
        }

        public static string 班級代碼設定 { get { return "SHEvaluation.Course.ReaderScoreImport02"; } }

        public static bool 班級代碼設定權限
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[班級代碼設定].Executable;
            }
        }

        public static string 試別代碼設定 { get { return "SHEvaluation.Course.ReaderScoreImport03"; } }

        public static bool 試別代碼設定權限
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[試別代碼設定].Executable;
            }
        }

        public static string 科目代碼設定 { get { return "SHEvaluation.Course.ReaderScoreImport04"; } }

        public static bool 科目代碼設定權限
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[科目代碼設定].Executable;
            }
        }
    }
}
