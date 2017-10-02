namespace MultiNIC
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lan = new System.Windows.Forms.Label();
            this.textBox_lan = new System.Windows.Forms.TextBox();
            this.textBox_lan_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lan_nexthop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lan_metric = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_lan = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_wan_metric = new System.Windows.Forms.TextBox();
            this.button_wan = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_wan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_wan_ip = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_wan_nexthop = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_usb_metric = new System.Windows.Forms.TextBox();
            this.button_usb = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_usb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_usb_ip = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_usb_nexthop = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_delete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lan
            // 
            this.lan.AutoSize = true;
            this.lan.Location = new System.Drawing.Point(6, 27);
            this.lan.Name = "lan";
            this.lan.Size = new System.Drawing.Size(53, 12);
            this.lan.TabIndex = 0;
            this.lan.Text = "本地连接";
            // 
            // textBox_lan
            // 
            this.textBox_lan.Location = new System.Drawing.Point(65, 24);
            this.textBox_lan.Name = "textBox_lan";
            this.textBox_lan.Size = new System.Drawing.Size(104, 21);
            this.textBox_lan.TabIndex = 2;
            this.textBox_lan.Text = "本地连接";
            // 
            // textBox_lan_ip
            // 
            this.textBox_lan_ip.Location = new System.Drawing.Point(65, 51);
            this.textBox_lan_ip.Name = "textBox_lan_ip";
            this.textBox_lan_ip.Size = new System.Drawing.Size(104, 21);
            this.textBox_lan_ip.TabIndex = 7;
            this.textBox_lan_ip.Text = "172.16.0.0/16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "路由前缀";
            // 
            // textBox_lan_nexthop
            // 
            this.textBox_lan_nexthop.Location = new System.Drawing.Point(65, 78);
            this.textBox_lan_nexthop.Name = "textBox_lan_nexthop";
            this.textBox_lan_nexthop.Size = new System.Drawing.Size(104, 21);
            this.textBox_lan_nexthop.TabIndex = 9;
            this.textBox_lan_nexthop.Text = "172.16.150.254";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "网关地址";
            // 
            // textBox_lan_metric
            // 
            this.textBox_lan_metric.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_lan_metric.Location = new System.Drawing.Point(65, 105);
            this.textBox_lan_metric.Name = "textBox_lan_metric";
            this.textBox_lan_metric.Size = new System.Drawing.Size(104, 21);
            this.textBox_lan_metric.TabIndex = 11;
            this.textBox_lan_metric.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "路由跃点";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_lan_metric);
            this.groupBox1.Controls.Add(this.button_lan);
            this.groupBox1.Controls.Add(this.lan);
            this.groupBox1.Controls.Add(this.textBox_lan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_lan_ip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_lan_nexthop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 171);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接1";
            // 
            // button_lan
            // 
            this.button_lan.Location = new System.Drawing.Point(65, 135);
            this.button_lan.Name = "button_lan";
            this.button_lan.Size = new System.Drawing.Size(104, 23);
            this.button_lan.TabIndex = 28;
            this.button_lan.Text = "添加路由";
            this.button_lan.UseVisualStyleBackColor = true;
            this.button_lan.Click += new System.EventHandler(this.button_lan_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_wan_metric);
            this.groupBox4.Controls.Add(this.button_wan);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox_wan);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox_wan_ip);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox_wan_nexthop);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(210, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 171);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "连接2";
            // 
            // textBox_wan_metric
            // 
            this.textBox_wan_metric.Location = new System.Drawing.Point(65, 105);
            this.textBox_wan_metric.Name = "textBox_wan_metric";
            this.textBox_wan_metric.Size = new System.Drawing.Size(104, 21);
            this.textBox_wan_metric.TabIndex = 11;
            this.textBox_wan_metric.Text = "2";
            // 
            // button_wan
            // 
            this.button_wan.Location = new System.Drawing.Point(65, 135);
            this.button_wan.Name = "button_wan";
            this.button_wan.Size = new System.Drawing.Size(104, 23);
            this.button_wan.TabIndex = 28;
            this.button_wan.Text = "添加路由";
            this.button_wan.UseVisualStyleBackColor = true;
            this.button_wan.Click += new System.EventHandler(this.button_wan_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "无线连接";
            // 
            // textBox_wan
            // 
            this.textBox_wan.Location = new System.Drawing.Point(65, 24);
            this.textBox_wan.Name = "textBox_wan";
            this.textBox_wan.Size = new System.Drawing.Size(104, 21);
            this.textBox_wan.TabIndex = 2;
            this.textBox_wan.Text = "WLAN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "路由前缀";
            // 
            // textBox_wan_ip
            // 
            this.textBox_wan_ip.Location = new System.Drawing.Point(65, 51);
            this.textBox_wan_ip.Name = "textBox_wan_ip";
            this.textBox_wan_ip.Size = new System.Drawing.Size(104, 21);
            this.textBox_wan_ip.TabIndex = 7;
            this.textBox_wan_ip.Text = "0.0.0.0/0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "网关地址";
            // 
            // textBox_wan_nexthop
            // 
            this.textBox_wan_nexthop.Location = new System.Drawing.Point(65, 78);
            this.textBox_wan_nexthop.Name = "textBox_wan_nexthop";
            this.textBox_wan_nexthop.Size = new System.Drawing.Size(104, 21);
            this.textBox_wan_nexthop.TabIndex = 9;
            this.textBox_wan_nexthop.Text = "192.168.43.1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "路由跃点";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_usb_metric);
            this.groupBox5.Controls.Add(this.button_usb);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBox_usb);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.textBox_usb_ip);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBox_usb_nexthop);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(409, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 171);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "连接3";
            // 
            // textBox_usb_metric
            // 
            this.textBox_usb_metric.Location = new System.Drawing.Point(65, 105);
            this.textBox_usb_metric.Name = "textBox_usb_metric";
            this.textBox_usb_metric.Size = new System.Drawing.Size(104, 21);
            this.textBox_usb_metric.TabIndex = 11;
            this.textBox_usb_metric.Text = "3";
            // 
            // button_usb
            // 
            this.button_usb.Location = new System.Drawing.Point(65, 135);
            this.button_usb.Name = "button_usb";
            this.button_usb.Size = new System.Drawing.Size(104, 23);
            this.button_usb.TabIndex = 28;
            this.button_usb.Text = "添加路由";
            this.button_usb.UseVisualStyleBackColor = true;
            this.button_usb.Click += new System.EventHandler(this.button_usb_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "USB共享";
            // 
            // textBox_usb
            // 
            this.textBox_usb.Location = new System.Drawing.Point(65, 24);
            this.textBox_usb.Name = "textBox_usb";
            this.textBox_usb.Size = new System.Drawing.Size(104, 21);
            this.textBox_usb.TabIndex = 2;
            this.textBox_usb.Text = "USB网络共享";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "路由前缀";
            // 
            // textBox_usb_ip
            // 
            this.textBox_usb_ip.Location = new System.Drawing.Point(65, 51);
            this.textBox_usb_ip.Name = "textBox_usb_ip";
            this.textBox_usb_ip.Size = new System.Drawing.Size(104, 21);
            this.textBox_usb_ip.TabIndex = 7;
            this.textBox_usb_ip.Text = "0.0.0.0/0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "网关地址";
            // 
            // textBox_usb_nexthop
            // 
            this.textBox_usb_nexthop.Location = new System.Drawing.Point(65, 78);
            this.textBox_usb_nexthop.Name = "textBox_usb_nexthop";
            this.textBox_usb_nexthop.Size = new System.Drawing.Size(104, 21);
            this.textBox_usb_nexthop.TabIndex = 9;
            this.textBox_usb_nexthop.Text = "192.168.42.129";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 10;
            this.label19.Text = "路由跃点";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "路由表信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(576, 220);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "ipconfig";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(183, 215);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(86, 23);
            this.button_delete.TabIndex = 38;
            this.button_delete.Text = "删除该路由";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_delete
            // 
            this.textBox_delete.Location = new System.Drawing.Point(77, 215);
            this.textBox_delete.Name = "textBox_delete";
            this.textBox_delete.Size = new System.Drawing.Size(100, 21);
            this.textBox_delete.TabIndex = 39;
            this.textBox_delete.Text = "0.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "路由前缀";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "恢复默认路由";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 486);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_delete);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "路由表设置";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lan;
        private System.Windows.Forms.TextBox textBox_lan;
        private System.Windows.Forms.TextBox textBox_lan_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lan_nexthop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lan_metric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_lan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_wan_metric;
        private System.Windows.Forms.Button button_wan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_wan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_wan_ip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_wan_nexthop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_usb_metric;
        private System.Windows.Forms.Button button_usb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_usb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_usb_ip;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_usb_nexthop;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
    }
}

