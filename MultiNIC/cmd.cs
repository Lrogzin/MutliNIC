using System;
using System.Diagnostics;


namespace MultiNIC
{
    public class Cmd
    {
        private Process proc = null;
        public Cmd()
        {   
            proc = new Process();
        }

        public string RunCmd(string cmd)
        {
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            proc.StandardInput.WriteLine("exit");
            string outStr = proc.StandardOutput.ReadToEnd();
            proc.Close();
            return outStr;
        }

        public String AddRoute(String prefix, String name, String nexthop, String metric) {
            String result = "";
            String cmd = string.Format("netsh interface ip add route prefix={0} interface=\"{1}\" nexthop={2} metric={3}",prefix,name,nexthop,metric);
            result = RunCmd(cmd);
            return result;
        }
    }
}