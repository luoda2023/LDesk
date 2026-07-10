namespace p2pconn
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnsg = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.r_chat = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRdp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtLocalHost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmyHost = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dspeed = new System.Windows.Forms.ComboBox();
            this.lblFPS = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblkb = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // — 颜色常量（扁平化浅色 + 蓝色主调） —
            System.Drawing.Color colorPrimary    = System.Drawing.ColorTranslator.FromHtml("#2563EB");
            System.Drawing.Color colorPrimaryDark = System.Drawing.ColorTranslator.FromHtml("#1D4ED8");
            System.Drawing.Color colorAccent     = System.Drawing.ColorTranslator.FromHtml("#EFF6FF");
            System.Drawing.Color colorBg         = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            System.Drawing.Color colorSurface    = System.Drawing.ColorTranslator.FromHtml("#F5F6F8");
            System.Drawing.Color colorBorder     = System.Drawing.ColorTranslator.FromHtml("#E5E7EB");
            System.Drawing.Color colorInk        = System.Drawing.ColorTranslator.FromHtml("#1F2937");
            System.Drawing.Color colorMuted      = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            System.Drawing.Color colorDanger     = System.Drawing.ColorTranslator.FromHtml("#DC2626");

            System.Drawing.Font fontRegular = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular);
            System.Drawing.Font fontBold    = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontSize    = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontMono    = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);

            // 
            // label3 — 对端 IP
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = colorBg;
            this.label3.Font = fontRegular;
            this.label3.ForeColor = colorInk;
            this.label3.Location = new System.Drawing.Point(30, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "对端 IP";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.BackColor = colorBg;
            this.txtRemoteIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemoteIP.Font = fontMono;
            this.txtRemoteIP.ForeColor = colorInk;
            this.txtRemoteIP.Location = new System.Drawing.Point(30, 186);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(380, 22);
            this.txtRemoteIP.TabIndex = 9;
            // 
            // button2 — 连接（主色全宽按钮）
            // 
            this.button2.BackColor = colorPrimary;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.BorderColor = colorPrimary;
            this.button2.FlatAppearance.MouseOverBackColor = colorPrimaryDark;
            this.button2.FlatAppearance.MouseDownBackColor = colorPrimaryDark;
            this.button2.Font = fontBold;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(492, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "连接";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4 — 状态栏
            // 
            this.label4.BackColor = colorSurface;
            this.label4.Font = fontRegular;
            this.label4.ForeColor = colorMuted;
            this.label4.Location = new System.Drawing.Point(30, 264);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(492, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "等待连接…";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtnsg — 消息输入框
            // 
            this.txtnsg.BackColor = colorBg;
            this.txtnsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnsg.Font = fontRegular;
            this.txtnsg.ForeColor = colorInk;
            this.txtnsg.Location = new System.Drawing.Point(30, 406);
            this.txtnsg.Multiline = true;
            this.txtnsg.Name = "txtnsg";
            this.txtnsg.Size = new System.Drawing.Size(380, 36);
            this.txtnsg.TabIndex = 15;
            // 
            // button4 — 发送
            // 
            this.button4.BackColor = colorPrimary;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.FlatAppearance.BorderColor = colorPrimary;
            this.button4.FlatAppearance.MouseOverBackColor = colorPrimaryDark;
            this.button4.FlatAppearance.MouseDownBackColor = colorPrimaryDark;
            this.button4.Font = fontBold;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(420, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 36);
            this.button4.TabIndex = 16;
            this.button4.Text = "发送";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_paste — 粘贴
            // 
            this.btn_paste.BackColor = colorBg;
            this.btn_paste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paste.FlatAppearance.BorderColor = colorBorder;
            this.btn_paste.FlatAppearance.MouseOverBackColor = colorAccent;
            this.btn_paste.FlatAppearance.MouseDownBackColor = colorSurface;
            this.btn_paste.Font = fontRegular;
            this.btn_paste.ForeColor = colorInk;
            this.btn_paste.Location = new System.Drawing.Point(420, 186);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(102, 22);
            this.btn_paste.TabIndex = 17;
            this.btn_paste.Text = "粘贴";
            this.btn_paste.UseVisualStyleBackColor = false;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // r_chat — 聊天区
            // 
            this.r_chat.BackColor = colorSurface;
            this.r_chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r_chat.Font = fontRegular;
            this.r_chat.ForeColor = colorInk;
            this.r_chat.Location = new System.Drawing.Point(30, 310);
            this.r_chat.Name = "r_chat";
            this.r_chat.ReadOnly = true;
            this.r_chat.Size = new System.Drawing.Size(492, 86);
            this.r_chat.TabIndex = 18;
            this.r_chat.Text = "";
            this.r_chat.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.r_chat_LinkClicked);
            this.r_chat.TextChanged += new System.EventHandler(this.r_chat_TextChanged);
            // 
            // button1 — 复制公网 IP
            // 
            this.button1.BackColor = colorBg;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.BorderColor = colorBorder;
            this.button1.FlatAppearance.MouseOverBackColor = colorAccent;
            this.button1.FlatAppearance.MouseDownBackColor = colorSurface;
            this.button1.Font = fontRegular;
            this.button1.ForeColor = colorInk;
            this.button1.Location = new System.Drawing.Point(420, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 22);
            this.button1.TabIndex = 19;
            this.button1.Text = "复制";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5 — 我的公网 IP
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = colorBg;
            this.label5.Font = fontRegular;
            this.label5.ForeColor = colorInk;
            this.label5.Location = new System.Drawing.Point(30, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "我的公网 IP";
            // 
            // btnRdp — 远程桌面（次操作）
            // 
            this.btnRdp.BackColor = colorAccent;
            this.btnRdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRdp.FlatAppearance.BorderColor = colorPrimary;
            this.btnRdp.FlatAppearance.MouseOverBackColor = colorPrimary;
            this.btnRdp.FlatAppearance.MouseDownBackColor = colorPrimaryDark;
            this.btnRdp.Font = fontBold;
            this.btnRdp.ForeColor = colorPrimary;
            this.btnRdp.Location = new System.Drawing.Point(420, 448);
            this.btnRdp.Name = "btnRdp";
            this.btnRdp.Size = new System.Drawing.Size(102, 24);
            this.btnRdp.TabIndex = 21;
            this.btnRdp.Text = "远程桌面";
            this.btnRdp.UseVisualStyleBackColor = false;
            this.btnRdp.Click += new System.EventHandler(this.btnRdp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 36);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(26, 7);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 516);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1 — 对端
            // 
            this.tabPage1.BackColor = colorBg;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtLocalHost);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtmyHost);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnRdp);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtRemoteIP);
            this.tabPage1.Controls.Add(this.r_chat);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btn_paste);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.txtnsg);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  对端  ";
            // 
            // button3 — 复制内网 IP
            // 
            this.button3.BackColor = colorBg;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.FlatAppearance.BorderColor = colorBorder;
            this.button3.FlatAppearance.MouseOverBackColor = colorAccent;
            this.button3.FlatAppearance.MouseDownBackColor = colorSurface;
            this.button3.Font = fontRegular;
            this.button3.ForeColor = colorInk;
            this.button3.Location = new System.Drawing.Point(420, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 22);
            this.button3.TabIndex = 25;
            this.button3.Text = "复制";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtLocalHost — 内网 IP 显示
            // 
            this.txtLocalHost.BackColor = colorSurface;
            this.txtLocalHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalHost.Font = fontMono;
            this.txtLocalHost.ForeColor = colorInk;
            this.txtLocalHost.Location = new System.Drawing.Point(30, 107);
            this.txtLocalHost.Name = "txtLocalHost";
            this.txtLocalHost.ReadOnly = true;
            this.txtLocalHost.Size = new System.Drawing.Size(380, 22);
            this.txtLocalHost.TabIndex = 24;
            // 
            // label13 — 我的内网 IP
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = colorBg;
            this.label13.Font = fontRegular;
            this.label13.ForeColor = colorInk;
            this.label13.Location = new System.Drawing.Point(30, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "我的内网 IP";
            // 
            // txtmyHost — 公网 IP 显示
            // 
            this.txtmyHost.BackColor = colorSurface;
            this.txtmyHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmyHost.Font = fontMono;
            this.txtmyHost.ForeColor = colorInk;
            this.txtmyHost.Location = new System.Drawing.Point(30, 47);
            this.txtmyHost.Name = "txtmyHost";
            this.txtmyHost.ReadOnly = true;
            this.txtmyHost.Size = new System.Drawing.Size(380, 22);
            this.txtmyHost.TabIndex = 22;
            // 
            // tabPage2 — STUN
            // 
            this.tabPage2.BackColor = colorBg;
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(552, 472);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "  STUN  ";
            // 
            // button7 — 保存
            // 
            this.button7.BackColor = colorPrimary;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.FlatAppearance.BorderColor = colorPrimary;
            this.button7.FlatAppearance.MouseOverBackColor = colorPrimaryDark;
            this.button7.FlatAppearance.MouseDownBackColor = colorPrimaryDark;
            this.button7.Font = fontBold;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(450, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 26);
            this.button7.TabIndex = 22;
            this.button7.Text = "保存";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6 — 删除
            // 
            this.button6.BackColor = colorBg;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.FlatAppearance.BorderColor = colorDanger;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#FEE2E2");
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#FECACA");
            this.button6.Font = fontRegular;
            this.button6.ForeColor = colorDanger;
            this.button6.Location = new System.Drawing.Point(372, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 26);
            this.button6.TabIndex = 21;
            this.button6.Text = "删除";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = colorBg;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Server,
            this.Port});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = colorBorder;
            this.dataGridView1.Location = new System.Drawing.Point(30, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(492, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // Server
            // 
            this.Server.DefaultCellStyle.BackColor = colorBg;
            this.Server.DefaultCellStyle.ForeColor = colorInk;
            this.Server.DefaultCellStyle.SelectionBackColor = colorAccent;
            this.Server.DefaultCellStyle.SelectionForeColor = colorPrimary;
            this.Server.HeaderText = "服务器";
            this.Server.Name = "Server";
            this.Server.Width = 320;
            // 
            // Port
            // 
            this.Port.DefaultCellStyle.BackColor = colorBg;
            this.Port.DefaultCellStyle.ForeColor = colorInk;
            this.Port.DefaultCellStyle.SelectionBackColor = colorAccent;
            this.Port.DefaultCellStyle.SelectionForeColor = colorPrimary;
            this.Port.HeaderText = "端口";
            this.Port.Name = "Port";
            this.Port.Width = 150;
            // 
            // tabPage3 — 桌面
            // 
            this.tabPage3.BackColor = colorBg;
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.dspeed);
            this.tabPage3.Controls.Add(this.lblFPS);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.lblkb);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "  桌面  ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = colorBg;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = fontRegular;
            this.checkBox1.ForeColor = colorInk;
            this.checkBox1.Location = new System.Drawing.Point(30, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "拉伸桌面画面";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dspeed
            // 
            this.dspeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dspeed.Enabled = false;
            this.dspeed.FormattingEnabled = true;
            this.dspeed.Font = fontRegular;
            this.dspeed.Items.AddRange(new object[] {
            "30",
            "50",
            "100",
            "200",
            "400",
            "800",
            "1000"});
            this.dspeed.Location = new System.Drawing.Point(80, 70);
            this.dspeed.Name = "dspeed";
            this.dspeed.Size = new System.Drawing.Size(72, 23);
            this.dspeed.TabIndex = 9;
            this.dspeed.SelectedIndexChanged += new System.EventHandler(this.dspeed_SelectedIndexChanged);
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.BackColor = System.Drawing.Color.Transparent;
            this.lblFPS.Font = fontSize;
            this.lblFPS.ForeColor = colorPrimary;
            this.lblFPS.Location = new System.Drawing.Point(80, 128);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(15, 20);
            this.lblFPS.TabIndex = 4;
            this.lblFPS.Text = "—";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = fontRegular;
            this.label15.ForeColor = colorMuted;
            this.label15.Location = new System.Drawing.Point(158, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "毫秒 / 帧";
            // 
            // lblkb
            // 
            this.lblkb.AutoSize = true;
            this.lblkb.BackColor = System.Drawing.Color.Transparent;
            this.lblkb.Font = fontSize;
            this.lblkb.ForeColor = colorPrimary;
            this.lblkb.Location = new System.Drawing.Point(80, 156);
            this.lblkb.Name = "lblkb";
            this.lblkb.Size = new System.Drawing.Size(15, 20);
            this.lblkb.TabIndex = 5;
            this.lblkb.Text = "—";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = fontRegular;
            this.label14.ForeColor = colorInk;
            this.label14.Location = new System.Drawing.Point(30, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "延迟";
            // 
            // tabPage4 — 关于
            // 
            this.tabPage4.BackColor = colorBg;
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(552, 472);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "  关于  ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = colorSurface;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = fontRegular;
            this.richTextBox1.ForeColor = colorInk;
            this.richTextBox1.Location = new System.Drawing.Point(120, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 110);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "基于 P2P 的远程桌面。\n\nGitHub: https://github.com/miroslavpejic85/p2p\n\n维基百科 (UDT 协议): https://en.wikipedia.org/wiki/UDP-based_Data_Transfer_Protocol";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::p2p.Properties.Resources.p2p1;
            this.pictureBox1.Location = new System.Drawing.Point(228, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorBg;
            this.ClientSize = new System.Drawing.Size(560, 518);
            this.Controls.Add(this.tabControl1);
            this.Font = fontRegular;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P2P 远程桌面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnsg;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.RichTextBox r_chat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRdp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtmyHost;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblkb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtLocalHost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox dspeed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
    }
}
