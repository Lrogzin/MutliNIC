using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //华软操作
            String ip = "";
            ip = cmd.GetIP();
            if (ip != "") {
                textBox_lan_nexthop.Text = cmd.GetGetway(ip);
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
            DialogResult dr = MessageBox.Show("恢复默认路由将删除0.0.0.0的路由，若您新增了其他路由，请手动删除！\n恢复过程请耐心等待几秒\n\n是否恢复默认路由？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cmd.RunCmd("route delete 0.0.0.0");
                richTextBox1.Text= cmd.RunCmd("ipconfig /renew");
            }
            
        }
    }
}
