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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();

            // —— Peer 选项卡控件 ——
            this.lblMyWanIp = new System.Windows.Forms.Label();
            this.txtmyHost = new System.Windows.Forms.TextBox();
            this.btnCopyWan = new System.Windows.Forms.Button();
            this.lblMyLanIp = new System.Windows.Forms.Label();
            this.txtLocalHost = new System.Windows.Forms.TextBox();
            this.btnCopyLan = new System.Windows.Forms.Button();
            this.lblPeerIp = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblChatTitle = new System.Windows.Forms.Label();
            this.r_chat = new System.Windows.Forms.RichTextBox();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.txtnsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRdp = new System.Windows.Forms.Button();

            // —— STUN 选项卡控件 ——
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // —— Desktop 选项卡控件 ——
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.dspeed = new System.Windows.Forms.ComboBox();
            this.lblMs = new System.Windows.Forms.Label();
            this.lblFpsTitle = new System.Windows.Forms.Label();
            this.lblFPS = new System.Windows.Forms.Label();
            this.lblFsizeTitle = new System.Windows.Forms.Label();
            this.lblkb = new System.Windows.Forms.Label();

            // —— About 选项卡控件 ——
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblAboutTitle = new System.Windows.Forms.Label();
            this.lblAboutSubtitle = new System.Windows.Forms.Label();

            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // ===========================================================
            // 颜色与字体常量（扁平化设计 — 浅色 + 蓝色主调）
            // ===========================================================
            System.Drawing.Color colorPrimary   = System.Drawing.ColorTranslator.FromHtml("#2563EB"); // 主色：钴蓝
            System.Drawing.Color colorPrimaryDark = System.Drawing.ColorTranslator.FromHtml("#1D4ED8"); // 主色按下
            System.Drawing.Color colorAccent     = System.Drawing.ColorTranslator.FromHtml("#EFF6FF"); // 浅蓝底
            System.Drawing.Color colorBg         = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); // 纯白
            System.Drawing.Color colorSurface   = System.Drawing.ColorTranslator.FromHtml("#F5F6F8"); // 浅灰面板
            System.Drawing.Color colorBorder    = System.Drawing.ColorTranslator.FromHtml("#E5E7EB"); // 边框
            System.Drawing.Color colorInk       = System.Drawing.ColorTranslator.FromHtml("#1F2937"); // 深蓝灰文字
            System.Drawing.Color colorMuted     = System.Drawing.ColorTranslator.FromHtml("#6B7280"); // 次要文字
            System.Drawing.Color colorSuccess  = System.Drawing.ColorTranslator.FromHtml("#059669"); // 成功绿
            System.Drawing.Color colorDanger    = System.Drawing.ColorTranslator.FromHtml("#DC2626"); // 危险红

            System.Drawing.Font fontRegular = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            System.Drawing.Font fontBold    = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold,    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            System.Drawing.Font fontSize    = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            System.Drawing.Font fontMono    = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            System.Drawing.Font fontTab     = new System.Drawing.Font("Microsoft YaHei UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = fontTab;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 38);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 480);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            //
            // tabPage1 — 对端
            //
            this.tabPage1.BackColor = colorBg;
            this.tabPage1.Controls.Add(this.lblMyWanIp);
            this.tabPage1.Controls.Add(this.txtmyHost);
            this.tabPage1.Controls.Add(this.btnCopyWan);
            this.tabPage1.Controls.Add(this.lblMyLanIp);
            this.tabPage1.Controls.Add(this.txtLocalHost);
            this.tabPage1.Controls.Add(this.btnCopyLan);
            this.tabPage1.Controls.Add(this.lblPeerIp);
            this.tabPage1.Controls.Add(this.txtRemoteIP);
            this.tabPage1.Controls.Add(this.btnPaste);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.lblChatTitle);
            this.tabPage1.Controls.Add(this.r_chat);
            this.tabPage1.Controls.Add(this.lblMessageTitle);
            this.tabPage1.Controls.Add(this.txtnsg);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.btnRdp);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  对端  ";
            //
            // tabPage2 — STUN
            //
            this.tabPage2.BackColor = colorBg;
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(552, 434);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "  STUN  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // tabPage3 — 桌面
            //
            this.tabPage3.BackColor = colorBg;
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.lblDelay);
            this.tabPage3.Controls.Add(this.dspeed);
            this.tabPage3.Controls.Add(this.lblMs);
            this.tabPage3.Controls.Add(this.lblFpsTitle);
            this.tabPage3.Controls.Add(this.lblFPS);
            this.tabPage3.Controls.Add(this.lblFsizeTitle);
            this.tabPage3.Controls.Add(this.lblkb);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "  桌面  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // tabPage4 — 关于
            //
            this.tabPage4.BackColor = colorBg;
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.lblAboutTitle);
            this.tabPage4.Controls.Add(this.lblAboutSubtitle);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(552, 434);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "  关于  ";
            this.tabPage4.UseVisualStyleBackColor = true;

            // ===========================================================
            // —— Peer 选项卡布局 ——
            // ===========================================================

            // —— 身份卡片（公网/内网 IP） ——
            //
            // lblMyWanIp（标签改为柔和深色文字，不在彩色背景上）
            //
            this.lblMyWanIp.AutoSize = true;
            this.lblMyWanIp.BackColor = colorBg;
            this.lblMyWanIp.Font = fontRegular;
            this.lblMyWanIp.ForeColor = colorInk;
            this.lblMyWanIp.Location = new System.Drawing.Point(30, 28);
            this.lblMyWanIp.Name = "lblMyWanIp";
            this.lblMyWanIp.Text = "我的公网 IP";
            //
            // txtmyHost
            //
            this.txtmyHost.BackColor = colorSurface;
            this.txtmyHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmyHost.Font = fontMono;
            this.txtmyHost.ForeColor = colorInk;
            this.txtmyHost.Location = new System.Drawing.Point(30, 50);
            this.txtmyHost.Name = "txtmyHost";
            this.txtmyHost.ReadOnly = true;
            this.txtmyHost.Size = new System.Drawing.Size(300, 23);
            this.txtmyHost.TabIndex = 22;
            //
            // btnCopyWan（扁平描边按钮）
            //
            this.btnCopyWan.BackColor = colorBg;
            this.btnCopyWan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyWan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyWan.FlatAppearance.BorderColor = colorBorder;
            this.btnCopyWan.FlatAppearance.MouseOverBackColor = colorAccent;
            this.btnCopyWan.FlatAppearance.MouseDownBackColor = colorSurface;
            this.btnCopyWan.Font = fontRegular;
            this.btnCopyWan.ForeColor = colorInk;
            this.btnCopyWan.Location = new System.Drawing.Point(338, 49);
            this.btnCopyWan.Name = "btnCopyWan";
            this.btnCopyWan.Size = new System.Drawing.Size(72, 25);
            this.btnCopyWan.TabIndex = 19;
            this.btnCopyWan.Text = "复制";
            this.btnCopyWan.UseVisualStyleBackColor = false;
            this.btnCopyWan.Click += new System.EventHandler(this.button1_Click);
            //
            // lblMyLanIp
            //
            this.lblMyLanIp.AutoSize = true;
            this.lblMyLanIp.BackColor = colorBg;
            this.lblMyLanIp.Font = fontRegular;
            this.lblMyLanIp.ForeColor = colorInk;
            this.lblMyLanIp.Location = new System.Drawing.Point(30, 88);
            this.lblMyLanIp.Name = "lblMyLanIp";
            this.lblMyLanIp.Text = "我的内网 IP";
            //
            // txtLocalHost
            //
            this.txtLocalHost.BackColor = colorSurface;
            this.txtLocalHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalHost.Font = fontMono;
            this.txtLocalHost.ForeColor = colorInk;
            this.txtLocalHost.Location = new System.Drawing.Point(30, 110);
            this.txtLocalHost.Name = "txtLocalHost";
            this.txtLocalHost.ReadOnly = true;
            this.txtLocalHost.Size = new System.Drawing.Size(300, 23);
            this.txtLocalHost.TabIndex = 24;
            //
            // btnCopyLan
            //
            this.btnCopyLan.BackColor = colorBg;
            this.btnCopyLan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyLan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyLan.FlatAppearance.BorderColor = colorBorder;
            this.btnCopyLan.FlatAppearance.MouseOverBackColor = colorAccent;
            this.btnCopyLan.FlatAppearance.MouseDownBackColor = colorSurface;
            this.btnCopyLan.Font = fontRegular;
            this.btnCopyLan.ForeColor = colorInk;
            this.btnCopyLan.Location = new System.Drawing.Point(338, 109);
            this.btnCopyLan.Name = "btnCopyLan";
            this.btnCopyLan.Size = new System.Drawing.Size(72, 25);
            this.btnCopyLan.TabIndex = 25;
            this.btnCopyLan.Text = "复制";
            this.btnCopyLan.UseVisualStyleBackColor = false;
            this.btnCopyLan.Click += new System.EventHandler(this.button3_Click);

            // —— 分隔线（用 Label 模拟） ——
            System.Windows.Forms.Label sep1 = new System.Windows.Forms.Label();
            sep1.BackColor = colorBorder;
            sep1.Location = new System.Drawing.Point(30, 152);
            sep1.Size = new System.Drawing.Size(492, 1);
            this.tabPage1.Controls.Add(sep1);

            // —— 对端连接 ——
            //
            // lblPeerIp
            //
            this.lblPeerIp.AutoSize = true;
            this.lblPeerIp.BackColor = colorBg;
            this.lblPeerIp.Font = fontRegular;
            this.lblPeerIp.ForeColor = colorInk;
            this.lblPeerIp.Location = new System.Drawing.Point(30, 168);
            this.lblPeerIp.Name = "lblPeerIp";
            this.lblPeerIp.Text = "对端 IP";
            //
            // txtRemoteIP
            //
            this.txtRemoteIP.BackColor = colorBg;
            this.txtRemoteIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemoteIP.Font = fontMono;
            this.txtRemoteIP.ForeColor = colorInk;
            this.txtRemoteIP.Location = new System.Drawing.Point(30, 190);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(380, 23);
            this.txtRemoteIP.TabIndex = 9;
            //
            // btnPaste
            //
            this.btnPaste.BackColor = colorBg;
            this.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.FlatAppearance.BorderColor = colorBorder;
            this.btnPaste.FlatAppearance.MouseOverBackColor = colorAccent;
            this.btnPaste.FlatAppearance.MouseDownBackColor = colorSurface;
            this.btnPaste.Font = fontRegular;
            this.btnPaste.ForeColor = colorInk;
            this.btnPaste.Location = new System.Drawing.Point(420, 189);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(102, 25);
            this.btnPaste.TabIndex = 17;
            this.btnPaste.Text = "粘贴";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btn_paste_Click);
            //
            // btnConnect（主色按钮）
            //
            this.btnConnect.BackColor = colorPrimary;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.FlatAppearance.BorderColor = colorPrimary;
            this.btnConnect.FlatAppearance.MouseOverBackColor = colorPrimaryDark;
            this.btnConnect.FlatAppearance.MouseDownBackColor = colorPrimaryDark;
            this.btnConnect.Font = fontBold;
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(30, 226);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(492, 34);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.button2_Click);
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = colorSurface;
            this.lblStatus.Font = fontRegular;
            this.lblStatus.ForeColor = colorMuted;
            this.lblStatus.Location = new System.Drawing.Point(30, 268);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(492, 22);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "  等待连接…";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // —— 聊天 ——
            //
            // lblChatTitle
            //
            this.lblChatTitle.AutoSize = true;
            this.lblChatTitle.BackColor = colorBg;
            this.lblChatTitle.Font = fontBold;
            this.lblChatTitle.ForeColor = colorInk;
            this.lblChatTitle.Location = new System.Drawing.Point(30, 302);
            this.lblChatTitle.Name = "lblChatTitle";
            this.lblChatTitle.Text = "聊天";
            //
            // r_chat
            //
            this.r_chat.BackColor = colorSurface;
            this.r_chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r_chat.Font = fontRegular;
            this.r_chat.ForeColor = colorInk;
            this.r_chat.Location = new System.Drawing.Point(30, 324);
            this.r_chat.Name = "r_chat";
            this.r_chat.ReadOnly = true;
            this.r_chat.Size = new System.Drawing.Size(492, 96);
            this.r_chat.TabIndex = 18;
            this.r_chat.Text = "";
            this.r_chat.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.r_chat_LinkClicked);
            this.r_chat.TextChanged += new System.EventHandler(this.r_chat_TextChanged);
            //
            // lblMessageTitle
            //
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.BackColor = colorBg;
            this.lblMessageTitle.Font = fontRegular;
            this.lblMessageTitle.ForeColor = colorMuted;
            this.lblMessageTitle.Location = new System.Drawing.Point(30, 430);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Text = "消息";
            //
            // txtnsg
            //
            this.txtnsg.BackColor = colorBg;
            this.txtnsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnsg.Font = fontRegular;
            this.txtnsg.ForeColor = colorInk;
            this.txtnsg.Location = new System.Drawing.Point(30, 450);
            this.txtnsg.Multiline = true;
            this.txtnsg.Name = "txtnsg";
            this.txtnsg.Size = new System.Drawing.Size(380, 50);
            this.txtnsg.TabIndex = 15;
            //
            // btnSend
            //
            this.btnSend.BackColor = colorPrimary;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.FlatAppearance.BorderColor = colorPrimary;
            this.btnSend.FlatAppearance.MouseOverBackColor = colorPrimaryDark;
            this.btnSend.FlatAppearance.MouseDownBackColor = colorPrimaryDark;
            this.btnSend.Font = fontBold;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(420, 450);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(102, 24);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button4_Click);
            //
            // btnRdp（用浅蓝底强调"远程桌面"是次主操作）
            //
            this.btnRdp.BackColor = colorAccent;
            this.btnRdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRdp.FlatAppearance.BorderColor = colorPrimary;
            this.btnRdp.FlatAppearance.MouseOverBackColor = colorPrimary;
            this.btnRdp.FlatAppearance.MouseDownBackColor = colorPrimary;
            this.btnRdp.Font = fontBold;
            this.btnRdp.ForeColor = colorPrimary;
            this.btnRdp.Location = new System.Drawing.Point(420, 478);
            this.btnRdp.Name = "btnRdp";
            this.btnRdp.Size = new System.Drawing.Size(102, 22);
            this.btnRdp.TabIndex = 21;
            this.btnRdp.Text = "远程桌面";
            this.btnRdp.UseVisualStyleBackColor = false;
            this.btnRdp.Click += new System.EventHandler(this.btnRdp_Click);

            // ===========================================================
            // —— STUN 选项卡布局 ——
            // ===========================================================

            // 工具条容器（用一个 Panel 模拟顶部工具栏）
            System.Windows.Forms.Panel stunToolbar = new System.Windows.Forms.Panel();
            stunToolbar.BackColor = colorBg;
            stunToolbar.Location = new System.Drawing.Point(0, 0);
            stunToolbar.Size = new System.Drawing.Size(552, 56);
            this.tabPage2.Controls.Add(stunToolbar);

            System.Windows.Forms.Label stunTitle = new System.Windows.Forms.Label();
            stunTitle.AutoSize = true;
            stunTitle.BackColor = colorBg;
            stunTitle.Font = fontSize;
            stunTitle.ForeColor = colorInk;
            stunTitle.Location = new System.Drawing.Point(30, 18);
            stunTitle.Text = "STUN 服务器";
            stunToolbar.Controls.Add(stunTitle);

            System.Windows.Forms.Label stunHint = new System.Windows.Forms.Label();
            stunHint.AutoSize = true;
            stunHint.BackColor = colorBg;
            stunHint.Font = fontRegular;
            stunHint.ForeColor = colorMuted;
            stunHint.Location = new System.Drawing.Point(170, 22);
            stunHint.Text = "用于探测公网 IP，可添加多个交替使用";
            stunToolbar.Controls.Add(stunHint);
            //
            // btnDelete（危险按钮 — 描边红色）
            //
            this.btnDelete.BackColor = colorBg;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = colorDanger;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#FEE2E2");
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#FECACA");
            this.btnDelete.Font = fontRegular;
            this.btnDelete.ForeColor = colorDanger;
            this.btnDelete.Location = new System.Drawing.Point(450, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 25);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button6_Click);
            stunToolbar.Controls.Add(this.btnDelete);
            //
            // btnSave（主色按钮）
            //
            this.btnSave.BackColor = colorPrimary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = colorPrimary;
            this.btnSave.FlatAppearance.MouseOverBackColor = colorPrimaryDark;
            this.btnSave.FlatAppearance.MouseDownBackColor = colorPrimaryDark;
            this.btnSave.Font = fontBold;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(372, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 25);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button7_Click);
            stunToolbar.Controls.Add(this.btnSave);
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(492, 350);
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

            // ===========================================================
            // —— Desktop 选项卡布局 ——
            // ===========================================================

            System.Windows.Forms.Label desktopTitle = new System.Windows.Forms.Label();
            desktopTitle.AutoSize = true;
            desktopTitle.BackColor = colorBg;
            desktopTitle.Font = fontSize;
            desktopTitle.ForeColor = colorInk;
            desktopTitle.Location = new System.Drawing.Point(30, 24);
            desktopTitle.Text = "远程桌面设置";
            this.tabPage3.Controls.Add(desktopTitle);

            System.Windows.Forms.Label desktopHint = new System.Windows.Forms.Label();
            desktopHint.AutoSize = true;
            desktopHint.BackColor = colorBg;
            desktopHint.Font = fontRegular;
            desktopHint.ForeColor = colorMuted;
            desktopHint.Location = new System.Drawing.Point(30, 54);
            desktopHint.Text = "建立连接并开启远程桌面后即可调整以下选项";
            this.tabPage3.Controls.Add(desktopHint);

            // 分隔线
            System.Windows.Forms.Label sep3 = new System.Windows.Forms.Label();
            sep3.BackColor = colorBorder;
            sep3.Location = new System.Drawing.Point(30, 88);
            sep3.Size = new System.Drawing.Size(492, 1);
            this.tabPage3.Controls.Add(sep3);
            //
            // checkBox1
            //
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = colorBg;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = fontRegular;
            this.checkBox1.ForeColor = colorInk;
            this.checkBox1.Location = new System.Drawing.Point(30, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "拉伸桌面画面";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            //
            // lblDelay
            //
            this.lblDelay.AutoSize = true;
            this.lblDelay.BackColor = colorBg;
            this.lblDelay.Font = fontRegular;
            this.lblDelay.ForeColor = colorInk;
            this.lblDelay.Location = new System.Drawing.Point(30, 148);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Text = "延迟";
            this.tabPage3.Controls.Add(this.lblDelay);
            //
            // dspeed
            //
            this.dspeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dspeed.Enabled = false;
            this.dspeed.FormattingEnabled = true;
            this.dspeed.Items.AddRange(new object[] {
            "30",
            "50",
            "100",
            "200",
            "400",
            "800",
            "1000"});
            this.dspeed.Location = new System.Drawing.Point(80, 145);
            this.dspeed.Name = "dspeed";
            this.dspeed.Size = new System.Drawing.Size(80, 23);
            this.dspeed.TabIndex = 9;
            this.dspeed.SelectedIndexChanged += new System.EventHandler(this.dspeed_SelectedIndexChanged);
            //
            // lblMs
            //
            this.lblMs.AutoSize = true;
            this.lblMs.BackColor = colorBg;
            this.lblMs.Font = fontRegular;
            this.lblMs.ForeColor = colorMuted;
            this.lblMs.Location = new System.Drawing.Point(168, 148);
            this.lblMs.Name = "lblMs";
            this.lblMs.Text = "毫秒 / 帧";
            this.tabPage3.Controls.Add(this.lblMs);

            // 分隔线
            System.Windows.Forms.Label sep4 = new System.Windows.Forms.Label();
            sep4.BackColor = colorBorder;
            sep4.Location = new System.Drawing.Point(30, 184);
            sep4.Size = new System.Drawing.Size(492, 1);
            this.tabPage3.Controls.Add(sep4);

            // —— 实时数据 ——
            System.Windows.Forms.Label statsTitle = new System.Windows.Forms.Label();
            statsTitle.AutoSize = true;
            statsTitle.BackColor = colorBg;
            statsTitle.Font = fontBold;
            statsTitle.ForeColor = colorInk;
            statsTitle.Location = new System.Drawing.Point(30, 204);
            statsTitle.Text = "实时统计";
            this.tabPage3.Controls.Add(statsTitle);
            //
            // lblFpsTitle
            //
            this.lblFpsTitle.AutoSize = true;
            this.lblFpsTitle.BackColor = colorBg;
            this.lblFpsTitle.Font = fontRegular;
            this.lblFpsTitle.ForeColor = colorMuted;
            this.lblFpsTitle.Location = new System.Drawing.Point(30, 240);
            this.lblFpsTitle.Name = "lblFpsTitle";
            this.lblFpsTitle.Text = "帧率";
            this.tabPage3.Controls.Add(this.lblFpsTitle);
            //
            // lblFPS（用主色突出数值，Mono 字体）
            //
            this.lblFPS.AutoSize = true;
            this.lblFPS.BackColor = colorBg;
            this.lblFPS.Font = fontSize;
            this.lblFPS.ForeColor = colorPrimary;
            this.lblFPS.Location = new System.Drawing.Point(80, 238);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Text = "—";
            this.tabPage3.Controls.Add(this.lblFPS);
            //
            // lblFsizeTitle
            //
            this.lblFsizeTitle.AutoSize = true;
            this.lblFsizeTitle.BackColor = colorBg;
            this.lblFsizeTitle.Font = fontRegular;
            this.lblFsizeTitle.ForeColor = colorMuted;
            this.lblFsizeTitle.Location = new System.Drawing.Point(30, 270);
            this.lblFsizeTitle.Name = "lblFsizeTitle";
            this.lblFsizeTitle.Text = "帧大小";
            this.tabPage3.Controls.Add(this.lblFsizeTitle);
            //
            // lblkb
            //
            this.lblkb.AutoSize = true;
            this.lblkb.BackColor = colorBg;
            this.lblkb.Font = fontSize;
            this.lblkb.ForeColor = colorPrimary;
            this.lblkb.Location = new System.Drawing.Point(80, 268);
            this.lblkb.Name = "lblkb";
            this.lblkb.Text = "—";
            this.tabPage3.Controls.Add(this.lblkb);

            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.dspeed);

            // ===========================================================
            // —— About 选项卡布局 ——
            // ===========================================================

            //
            // pictureBox1
            //
            this.pictureBox1.Image = global::p2p.Properties.Resources.p2p1;
            this.pictureBox1.Location = new System.Drawing.Point(216, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //
            // lblAboutTitle
            //
            this.lblAboutTitle.AutoSize = true;
            this.lblAboutTitle.BackColor = colorBg;
            this.lblAboutTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutTitle.ForeColor = colorInk;
            this.lblAboutTitle.Location = new System.Drawing.Point(176, 150);
            this.lblAboutTitle.Name = "lblAboutTitle";
            this.lblAboutTitle.Text = "P2P 远程桌面";
            this.tabPage4.Controls.Add(this.lblAboutTitle);
            //
            // lblAboutSubtitle
            //
            this.lblAboutSubtitle.AutoSize = true;
            this.lblAboutSubtitle.BackColor = colorBg;
            this.lblAboutSubtitle.Font = fontRegular;
            this.lblAboutSubtitle.ForeColor = colorMuted;
            this.lblAboutSubtitle.Location = new System.Drawing.Point(150, 184);
            this.lblAboutSubtitle.Name = "lblAboutSubtitle";
            this.lblAboutSubtitle.Text = "基于 P2P 的远程控制工具 · 便携、免安装、免配置";
            this.tabPage4.Controls.Add(this.lblAboutSubtitle);
            //
            // richTextBox1
            //
            this.richTextBox1.BackColor = colorSurface;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = fontRegular;
            this.richTextBox1.ForeColor = colorInk;
            this.richTextBox1.Location = new System.Drawing.Point(120, 230);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 110);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "基于 P2P 的远程桌面。\n\nGitHub: https://github.com/miroslavpejic85/p2p\n\n维基百科 (UDT 协议): https://en.wikipedia.org/wiki/UDP-based_Data_Transfer_Protocol";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            this.tabPage4.Controls.Add(this.richTextBox1);

            // ===========================================================
            // —— Form1 主窗口 ——
            // ===========================================================
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorBg;
            this.ClientSize = new System.Drawing.Size(560, 482);
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

        // —— 主窗口控件 ——
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        // —— Peer 选项卡 ——
        private System.Windows.Forms.Label lblMyWanIp;
        private System.Windows.Forms.TextBox txtmyHost;
        private System.Windows.Forms.Button btnCopyWan;
        private System.Windows.Forms.Label lblMyLanIp;
        private System.Windows.Forms.TextBox txtLocalHost;
        private System.Windows.Forms.Button btnCopyLan;
        private System.Windows.Forms.Label lblPeerIp;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblChatTitle;
        private System.Windows.Forms.RichTextBox r_chat;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.TextBox txtnsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRdp;

        // —— STUN 选项卡 ——
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;

        // —— Desktop 选项卡 ——
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.ComboBox dspeed;
        private System.Windows.Forms.Label lblMs;
        private System.Windows.Forms.Label lblFpsTitle;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblFsizeTitle;
        private System.Windows.Forms.Label lblkb;

        // —— About 选项卡 ——
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblAboutTitle;
        private System.Windows.Forms.Label lblAboutSubtitle;

        // —— 兼容旧字段名（保留以避免 Form1.cs 编译错误，等 Form1.cs 同步更新后可删除） ——
        private System.Windows.Forms.Button button2 { get { return btnConnect; } }
        private System.Windows.Forms.Button button4 { get { return btnSend; } }
        private System.Windows.Forms.Button btn_paste { get { return this.btnPaste; } }
        private System.Windows.Forms.Button button1 { get { return btnCopyWan; } }
        private System.Windows.Forms.Button button3 { get { return btnCopyLan; } }
        private System.Windows.Forms.Button button6 { get { return btnDelete; } }
        private System.Windows.Forms.Button button7 { get { return btnSave; } }
        private System.Windows.Forms.Label label3 { get { return lblPeerIp; } }
        private System.Windows.Forms.Label label4 { get { return lblStatus; } }
        private System.Windows.Forms.Label label5 { get { return lblMyWanIp; } }
        private System.Windows.Forms.Label label13 { get { return lblMyLanIp; } }
        private System.Windows.Forms.Label label14 { get { return lblDelay; } }
        private System.Windows.Forms.Label label15 { get { return lblMs; } }
    }
}
