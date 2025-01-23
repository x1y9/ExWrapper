using System.Diagnostics;
using System.IO;

namespace ExWrapper.Wrapper
{
    class Program
    {
        //使用@避免转义，唯一需要转义的符号是双引号，要写两个双引号
        private static string embedContent = @"${embed}";
        private static string callCmd = @"${cmd}";
        private static string callPara = @"${para}";
        private static string callDir = @"${dir}";
        private static string hideConsole = @"${hide}";


        public static Process RunProcess(string path, string command, string argument,
            bool hide = false, bool shell=false)
        {
            var p = new Process();
            p.StartInfo.WorkingDirectory = path;
                
            p.StartInfo.FileName = command; 
            p.StartInfo.Arguments = argument;

            //要支持重定向，必须将UseShellExecute置为false
            p.StartInfo.UseShellExecute = shell;
            p.StartInfo.CreateNoWindow = hide;
            p.Start();
            p.WaitForExit();
            return p;
        }
        
        static void Main(string[] args)
        {
            var para = string.Join(" ", args);
            if (!embedContent.StartsWith("${"))
            {
                string tempFile = Path.Combine(Path.GetTempPath(), System.Guid.NewGuid() + ".bat");
                File.WriteAllText(tempFile, embedContent);
                try
                {
                    RunProcess("", tempFile, para, hideConsole.Equals("true"));
                }
                finally
                {
                    File.Delete(tempFile);
                }
            }
            else if (!callCmd.StartsWith("${"))
            {
                RunProcess(callDir, callCmd, string.Join(" ",callPara, para), hideConsole.Equals("true"));
            }
        }
    }
}
