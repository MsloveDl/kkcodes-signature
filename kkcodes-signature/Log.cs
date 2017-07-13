using System;
using System.IO;
using System.Windows.Forms;

namespace kkcodes_signature
{
    class Log
    {
        private string strLogPath = "";
        private StreamWriter streamWriterLogo = null;

        public Log()
        {
            strLogPath = Application.StartupPath;
        }

        /// <summary>
        /// 打开日志文件并查找到文件文, 如果日志文件不存在则创建
        /// </summary>
        /// <returns>成功打开/创建返回true, 其他返回false</returns>
        public bool AppendLog()
        {
            if (null != streamWriterLogo)
                return false;

            streamWriterLogo = new StreamWriter(strLogPath + "/log.txt", true);
            return true;
        }

        /// <summary>
        /// 将指定内容写入到日志文件(fileLog), 并且返回成功写入的内容长度
        /// </summary>
        /// <param name="strContent">要写入的内容</param>
        /// <returns>成功写入的内容长度</returns>
        public int WriteLog(string strContent)
        {
            string strTemp = DateTime.Now.ToString() + "\tAlert Message: " + strContent;

            streamWriterLogo.WriteLine(strTemp);
            streamWriterLogo.Flush();
            streamWriterLogo.Close();
            streamWriterLogo.Dispose();

            streamWriterLogo = null;

            return strContent.Length;
        }
    }
}
