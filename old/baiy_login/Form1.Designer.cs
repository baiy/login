namespace baiyLogin
{
    partial class form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonsshlink = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonftplink = new System.Windows.Forms.Button();
            this.comboBoxftpprotocol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxftpport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxftppassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxftpusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxftphost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewftp = new System.Windows.Forms.DataGridView();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonmstsclink = new System.Windows.Forms.Button();
            this.dataGridViewmstsc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxmstscpassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxmstscport = new System.Windows.Forms.TextBox();
            this.textBoxmstschost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxmstscusername = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxsshpassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxsshport = new System.Windows.Forms.TextBox();
            this.textBoxsshhost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxsshusername = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridViewssh = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxsshpath = new System.Windows.Forms.TextBox();
            this.textBoxftppath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Textencryptkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textapiurl = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxftpcmd = new System.Windows.Forms.TextBox();
            this.textBoxsshcmd = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonsshlink.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewftp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmstsc)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewssh)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsshlink
            // 
            this.buttonsshlink.Controls.Add(this.tabPage1);
            this.buttonsshlink.Controls.Add(this.tabPage2);
            this.buttonsshlink.Controls.Add(this.tabPage3);
            this.buttonsshlink.Controls.Add(this.tabPage4);
            this.buttonsshlink.Location = new System.Drawing.Point(12, 12);
            this.buttonsshlink.Name = "buttonsshlink";
            this.buttonsshlink.SelectedIndex = 0;
            this.buttonsshlink.Size = new System.Drawing.Size(839, 436);
            this.buttonsshlink.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.buttonsshlink.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonftplink);
            this.tabPage1.Controls.Add(this.comboBoxftpprotocol);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxftpport);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxftppassword);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxftpusername);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxftphost);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridViewftp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FTP/SFTP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonftplink
            // 
            this.buttonftplink.Location = new System.Drawing.Point(750, 374);
            this.buttonftplink.Name = "buttonftplink";
            this.buttonftplink.Size = new System.Drawing.Size(75, 23);
            this.buttonftplink.TabIndex = 11;
            this.buttonftplink.Text = "快速连接";
            this.buttonftplink.UseVisualStyleBackColor = true;
            this.buttonftplink.Click += new System.EventHandler(this.buttonftplink_Click);
            // 
            // comboBoxftpprotocol
            // 
            this.comboBoxftpprotocol.FormattingEnabled = true;
            this.comboBoxftpprotocol.Items.AddRange(new object[] {
            "ftp",
            "sftp"});
            this.comboBoxftpprotocol.Location = new System.Drawing.Point(683, 377);
            this.comboBoxftpprotocol.Name = "comboBoxftpprotocol";
            this.comboBoxftpprotocol.Size = new System.Drawing.Size(57, 20);
            this.comboBoxftpprotocol.TabIndex = 10;
            this.comboBoxftpprotocol.Text = "ftp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "协议";
            // 
            // textBoxftpport
            // 
            this.textBoxftpport.Location = new System.Drawing.Point(570, 377);
            this.textBoxftpport.Name = "textBoxftpport";
            this.textBoxftpport.Size = new System.Drawing.Size(57, 21);
            this.textBoxftpport.TabIndex = 8;
            this.textBoxftpport.Text = "21";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "端口";
            // 
            // textBoxftppassword
            // 
            this.textBoxftppassword.Location = new System.Drawing.Point(396, 377);
            this.textBoxftppassword.Name = "textBoxftppassword";
            this.textBoxftppassword.PasswordChar = '*';
            this.textBoxftppassword.Size = new System.Drawing.Size(116, 21);
            this.textBoxftppassword.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "密码";
            // 
            // textBoxftpusername
            // 
            this.textBoxftpusername.Location = new System.Drawing.Point(227, 377);
            this.textBoxftpusername.Name = "textBoxftpusername";
            this.textBoxftpusername.Size = new System.Drawing.Size(116, 21);
            this.textBoxftpusername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户名";
            // 
            // textBoxftphost
            // 
            this.textBoxftphost.Location = new System.Drawing.Point(50, 378);
            this.textBoxftphost.Name = "textBoxftphost";
            this.textBoxftphost.Size = new System.Drawing.Size(116, 21);
            this.textBoxftphost.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "主机";
            // 
            // dataGridViewftp
            // 
            this.dataGridViewftp.AllowUserToDeleteRows = false;
            this.dataGridViewftp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewftp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewftp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.host,
            this.username,
            this.port,
            this.protocol,
            this.remarks,
            this.pasword});
            this.dataGridViewftp.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewftp.Name = "dataGridViewftp";
            this.dataGridViewftp.ReadOnly = true;
            this.dataGridViewftp.RowTemplate.Height = 23;
            this.dataGridViewftp.Size = new System.Drawing.Size(822, 357);
            this.dataGridViewftp.TabIndex = 0;
            this.dataGridViewftp.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewftp_CellContentDoubleClick);
            // 
            // host
            // 
            this.host.HeaderText = "主机";
            this.host.Name = "host";
            this.host.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "用户名";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // port
            // 
            this.port.HeaderText = "端口";
            this.port.Name = "port";
            this.port.ReadOnly = true;
            // 
            // protocol
            // 
            this.protocol.HeaderText = "协议";
            this.protocol.Name = "protocol";
            this.protocol.ReadOnly = true;
            // 
            // remarks
            // 
            this.remarks.HeaderText = "备注";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // pasword
            // 
            this.pasword.HeaderText = "密码";
            this.pasword.Name = "pasword";
            this.pasword.ReadOnly = true;
            this.pasword.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonmstsclink);
            this.tabPage2.Controls.Add(this.dataGridViewmstsc);
            this.tabPage2.Controls.Add(this.textBoxmstscpassword);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textBoxmstscport);
            this.tabPage2.Controls.Add(this.textBoxmstschost);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBoxmstscusername);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "远程连接";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonmstsclink
            // 
            this.buttonmstsclink.Location = new System.Drawing.Point(744, 376);
            this.buttonmstsclink.Name = "buttonmstsclink";
            this.buttonmstsclink.Size = new System.Drawing.Size(75, 23);
            this.buttonmstsclink.TabIndex = 22;
            this.buttonmstsclink.Text = "快速连接";
            this.buttonmstsclink.UseVisualStyleBackColor = true;
            this.buttonmstsclink.Click += new System.EventHandler(this.buttonmstsclink_Click);
            // 
            // dataGridViewmstsc
            // 
            this.dataGridViewmstsc.AllowUserToDeleteRows = false;
            this.dataGridViewmstsc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewmstsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmstsc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewmstsc.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewmstsc.Name = "dataGridViewmstsc";
            this.dataGridViewmstsc.ReadOnly = true;
            this.dataGridViewmstsc.RowTemplate.Height = 23;
            this.dataGridViewmstsc.Size = new System.Drawing.Size(822, 357);
            this.dataGridViewmstsc.TabIndex = 1;
            this.dataGridViewmstsc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmstsc_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "主机";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "用户名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "端口";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "备注";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "密码";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // textBoxmstscpassword
            // 
            this.textBoxmstscpassword.Location = new System.Drawing.Point(390, 379);
            this.textBoxmstscpassword.Name = "textBoxmstscpassword";
            this.textBoxmstscpassword.PasswordChar = '*';
            this.textBoxmstscpassword.Size = new System.Drawing.Size(116, 21);
            this.textBoxmstscpassword.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "主机";
            // 
            // textBoxmstscport
            // 
            this.textBoxmstscport.Location = new System.Drawing.Point(564, 379);
            this.textBoxmstscport.Name = "textBoxmstscport";
            this.textBoxmstscport.Size = new System.Drawing.Size(57, 21);
            this.textBoxmstscport.TabIndex = 19;
            this.textBoxmstscport.Text = "3389";
            // 
            // textBoxmstschost
            // 
            this.textBoxmstschost.Location = new System.Drawing.Point(44, 380);
            this.textBoxmstschost.Name = "textBoxmstschost";
            this.textBoxmstschost.Size = new System.Drawing.Size(116, 21);
            this.textBoxmstschost.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "端口";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "用户名";
            // 
            // textBoxmstscusername
            // 
            this.textBoxmstscusername.Location = new System.Drawing.Point(221, 379);
            this.textBoxmstscusername.Name = "textBoxmstscusername";
            this.textBoxmstscusername.Size = new System.Drawing.Size(116, 21);
            this.textBoxmstscusername.TabIndex = 15;
            this.textBoxmstscusername.Text = "Administrator";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "密码";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBoxsshpassword);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBoxsshport);
            this.tabPage3.Controls.Add(this.textBoxsshhost);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.textBoxsshusername);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.dataGridViewssh);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(831, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "linux命令行";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(744, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "快速连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxsshpassword
            // 
            this.textBoxsshpassword.Location = new System.Drawing.Point(390, 377);
            this.textBoxsshpassword.Name = "textBoxsshpassword";
            this.textBoxsshpassword.PasswordChar = '*';
            this.textBoxsshpassword.Size = new System.Drawing.Size(116, 21);
            this.textBoxsshpassword.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "主机";
            // 
            // textBoxsshport
            // 
            this.textBoxsshport.Location = new System.Drawing.Point(564, 377);
            this.textBoxsshport.Name = "textBoxsshport";
            this.textBoxsshport.Size = new System.Drawing.Size(57, 21);
            this.textBoxsshport.TabIndex = 30;
            this.textBoxsshport.Text = "22";
            // 
            // textBoxsshhost
            // 
            this.textBoxsshhost.Location = new System.Drawing.Point(44, 378);
            this.textBoxsshhost.Name = "textBoxsshhost";
            this.textBoxsshhost.Size = new System.Drawing.Size(116, 21);
            this.textBoxsshhost.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(529, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 29;
            this.label15.Text = "端口";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(174, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "用户名";
            // 
            // textBoxsshusername
            // 
            this.textBoxsshusername.Location = new System.Drawing.Point(221, 377);
            this.textBoxsshusername.Name = "textBoxsshusername";
            this.textBoxsshusername.Size = new System.Drawing.Size(116, 21);
            this.textBoxsshusername.TabIndex = 26;
            this.textBoxsshusername.Text = "root";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(355, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 27;
            this.label17.Text = "密码";
            // 
            // dataGridViewssh
            // 
            this.dataGridViewssh.AllowUserToDeleteRows = false;
            this.dataGridViewssh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewssh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewssh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewssh.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewssh.Name = "dataGridViewssh";
            this.dataGridViewssh.ReadOnly = true;
            this.dataGridViewssh.RowTemplate.Height = 23;
            this.dataGridViewssh.Size = new System.Drawing.Size(822, 357);
            this.dataGridViewssh.TabIndex = 2;
            this.dataGridViewssh.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewssh_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "主机";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "用户名";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "端口";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "备注";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "密码";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.textBoxsshcmd);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.textBoxftpcmd);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.textBoxsshpath);
            this.tabPage4.Controls.Add(this.textBoxftppath);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.Textencryptkey);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.textapiurl);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(831, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "设 置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(523, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "选择文件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SelectSshPath_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "选择文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SelectFtpPath_Click);
            // 
            // textBoxsshpath
            // 
            this.textBoxsshpath.Location = new System.Drawing.Point(107, 177);
            this.textBoxsshpath.Name = "textBoxsshpath";
            this.textBoxsshpath.Size = new System.Drawing.Size(410, 21);
            this.textBoxsshpath.TabIndex = 9;
            // 
            // textBoxftppath
            // 
            this.textBoxftppath.Location = new System.Drawing.Point(107, 97);
            this.textBoxftppath.Name = "textBoxftppath";
            this.textBoxftppath.Size = new System.Drawing.Size(410, 21);
            this.textBoxftppath.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "SSH软件路径";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "FTP软件路径";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "保 存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetConfig_Click);
            // 
            // Textencryptkey
            // 
            this.Textencryptkey.Location = new System.Drawing.Point(107, 53);
            this.Textencryptkey.Name = "Textencryptkey";
            this.Textencryptkey.Size = new System.Drawing.Size(410, 21);
            this.Textencryptkey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "通讯密钥";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "账号 API 地址";
            // 
            // textapiurl
            // 
            this.textapiurl.Location = new System.Drawing.Point(107, 14);
            this.textapiurl.Name = "textapiurl";
            this.textapiurl.Size = new System.Drawing.Size(410, 21);
            this.textapiurl.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "FTP启动模板";
            // 
            // textBoxftpcmd
            // 
            this.textBoxftpcmd.Location = new System.Drawing.Point(107, 138);
            this.textBoxftpcmd.Name = "textBoxftpcmd";
            this.textBoxftpcmd.Size = new System.Drawing.Size(410, 21);
            this.textBoxftpcmd.TabIndex = 13;
            // 
            // textBoxsshcmd
            // 
            this.textBoxsshcmd.Location = new System.Drawing.Point(107, 215);
            this.textBoxsshcmd.Name = "textBoxsshcmd";
            this.textBoxsshcmd.Size = new System.Drawing.Size(410, 21);
            this.textBoxsshcmd.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 14;
            this.label19.Text = "SSH启动模板";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(105, 287);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(281, 60);
            this.label20.TabIndex = 17;
            this.label20.Text = "启动模板变量:{name}\r\nFTP启动模板:\r\n{protocol},{username},{password},{host},{port}\r\nSSH启动模板:" +
    "\r\n{host},{port},{username},{password}";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(523, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 18;
            this.label21.Text = "*";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 459);
            this.Controls.Add(this.buttonsshlink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "BAIY集成登录";
            this.Load += new System.EventHandler(this.form1_Load);
            this.buttonsshlink.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewftp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmstsc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewssh)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl buttonsshlink;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textapiurl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Textencryptkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewftp;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasword;
        private System.Windows.Forms.DataGridView dataGridViewmstsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridViewssh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button buttonftplink;
        private System.Windows.Forms.ComboBox comboBoxftpprotocol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxftpport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxftppassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxftpusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxftphost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxsshpath;
        private System.Windows.Forms.TextBox textBoxftppath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonmstsclink;
        private System.Windows.Forms.TextBox textBoxmstscpassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxmstscport;
        private System.Windows.Forms.TextBox textBoxmstschost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxmstscusername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxsshpassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxsshport;
        private System.Windows.Forms.TextBox textBoxsshhost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxsshusername;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxsshcmd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxftpcmd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
    }
}

