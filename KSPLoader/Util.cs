using System.IO;
using System.Text;

namespace KSPLoader
{

    namespace Util
    {

        public static class SimpleFileLog
        {

            public static void OpenLog(string relativePath)
            {
                if (m_File != null)
                {
                    return;
                }

                var path = Path.Combine(KSPUtil.ApplicationRootPath, relativePath);
                m_File = File.Open(path, FileMode.Create, FileAccess.Write);
            }

            public static void LogString(string s)
            {
                if (m_File == null)
                {
                    return;
                }

                var bytes = Encoding.UTF8.GetBytes(s + "\n");
                m_File.Write(bytes, 0, bytes.Length);
                m_File.Flush();
            }

            private static FileStream m_File = null;

        }

    }

}
