using System;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MultiNIC
{
    public partial class Form1 : Form
    {
        Cmd cmd = new Cmd();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator()) {
                MessageBox.Show("获取管理员权限失败，请以管理员权限运行！");
                System.Environment.Exit(0);
            }
            //华软操作
            String ip = "";
            ip = GetIP();
            if (ip != "") {
                textBox_lan_nexthop.Text = GetGetway(ip);
                cmd.RunCmd("route add 1.1.1.1/32 " + textBox_lan_nexthop.Text);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = cmd.RunCmd("route print -4");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= cmd.RunCmd("ipconfig");
        }

        private void button_lan_Click(object sender, EventArgs e)
        {
            String result = "";
            result=cmd.AddRoute(textBox_lan_ip.Text, textBox_lan.Text, textBox_lan_nexthop.Text, textBox_lan_metric.Text);
            richTextBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = cmd.RunCmd("route delete "+textBox_delete.Text);
        }

        private void button_wan_Click(object sender, EventArgs e)
        {
            String result = "";
            result = cmd.AddRoute(textBox_wan_ip.Text, textBox_wan.Text, textBox_wan_nexthop.Text, textBox_wan_metric.Text);
            richTextBox1.Text = result;
        }

        private void button_usb_Click(object sender, EventArgs e)
        {
            String result = "";
            result = cmd.AddRoute(textBox_usb_ip.Text, textBox_usb.Text, textBox_usb_nexthop.Text, textBox_usb_metric.Text);
            richTextBox1.Text = result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = cmd.RunCmd("netsh interface ip add route /?");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("恢复过程请耐心等待几秒\n\n是否恢复默认路由？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cmd.RunCmd("route -f");
                cmd.RunCmd("ipconfig /release");
                cmd.RunCmd("ipconfig /renew");
                richTextBox1.Text = cmd.RunCmd("route print -4");
                MessageBox.Show("恢复完成！");
            }
            
        }

        public bool IsAdministrator()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public string GetIP()
        {
            String ip = "";
            System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://1.1.1.1:8000/ext_portal.magi?url=http://www.baidu.com/&radnum=155358&a.magi");
            request.Method = "GET";
            request.ContentType = "text/html;charset=gb2312";
            request.UserAgent = null;
            request.Timeout = 6000;
            try
            {
                System.Net.HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, System.Text.Encoding.GetEncoding("gb2312"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                ip = GetValue(retString, "userip=", "&wlanacname");

            }
            catch (Exception ex)
            {
                return "";
            }
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
            String getway = ip.Replace(rg.Match(ip).Value, ".254");
            return getway;
        }
    }
}
