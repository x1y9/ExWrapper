using System.Diagnostics;
using System.IO;

namespace ExWrapper.Wrapper
{
    class Program
    {
        private static string embedContent = "${embed}";
        private static string callCmd = "${cmd}";
        private static string callPara = "${para}";
        private static string callDir = "${dir}";

        private static string tempFile = "_exwraper_temp_.bat";
        private static bool redirectStandardOutput = true;

        public static Process RunProcess(string path, string command, string argument,
            bool hide = false, bool redirectInput = false, bool shell=false)
        {
            var p = new Process();
            p.StartInfo.WorkingDirectory = path;
                
            //适配两种情况，比如cmd.exe /c aaa.bat或者直接写aaa.bat
            p.StartInfo.FileName = command; 
            p.StartInfo.Arguments = argument;

            //要支持重定向，必须将UseShellExecute置为false
            p.StartInfo.UseShellExecute = shell;
            p.StartInfo.CreateNoWindow = hide;
            p.Start();

            return p;
        }
        
        static void Main2(string[] args)
        {
            embedContent = "";
            embedContent += "\r\n";

            if (!embedContent.StartsWith("${"))
            {
                
                File.WriteAllText(tempFile, embedContent);
                try
                {
                    RunProcess("", tempFile, "");
                }
                finally
                {
                    File.Delete(tempFile);
                }
            }
            else if (!callCmd.StartsWith("${"))
            {
                RunProcess(callDir, callCmd, callPara);
            }
        }
    }
}
