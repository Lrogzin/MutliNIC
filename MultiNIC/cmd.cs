using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

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
            String cmd = string.Format("netsh interface ip add route prefix={0} interface={1} nexthop={2} metric={3}",prefix,name,nexthop,metric);
            result = RunCmd(cmd);
            return result;
        }

        public string GetIP()
        {
            System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://1.1.1.1:8000/ext_portal.magi?url=http://www.baidu.com/&radnum=155358&a.magi");
            request.Method = "GET";
            request.ContentType = "text/html;charset=gb2312";
            request.UserAgent = null;
            request.Timeout = 3000;
            System.Net.HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, System.Text.Encoding.GetEncoding("gb2312"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            String ip = GetValue(retString, "userip=", "&wlanacname");
            return ip;
        }

        public string GetValue(string str, string s, string e)
        {
            Regex rg = new Regex("(?<=(" + s + "))[.\\s\\S]*?(?=(" + e + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(str).Value;
        }

        public string GetGetway(string ip)
        {
            Regex rg = new Regex("\\.\\d{1,3}$", RegexOptions.Multiline | RegexOptions.Singleline);
            String getway=ip.Replace(rg.Match(ip).Value, ".254");
            return getway;
        }

    }
}