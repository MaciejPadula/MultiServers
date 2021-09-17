namespace MultiServers
{
    partial class InstanceWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstanceWindow));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NetworkSettings = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IPA = new System.Windows.Forms.Label();
            this.IPPort = new System.Windows.Forms.TextBox();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.instSettings = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinRam = new System.Windows.Forms.TextBox();
            this.MaxRam = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ServerSettings = new System.Windows.Forms.Panel();
            this.enablecommandblocks = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.allowflight = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.difficultyCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PVP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxPlayer = new System.Windows.Forms.TextBox();
            this.OnlineMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mods = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.iconA = new System.Windows.Forms.PictureBox();
            this.NetworkSettings.SuspendLayout();
            this.instSettings.SuspendLayout();
            this.ServerSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconA)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(434, 323);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(13, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // NetworkSettings
            // 
            this.NetworkSettings.Controls.Add(this.label1);
            this.NetworkSettings.Controls.Add(this.IPA);
            this.NetworkSettings.Controls.Add(this.IPPort);
            this.NetworkSettings.Controls.Add(this.IPAddress);
            this.NetworkSettings.Location = new System.Drawing.Point(469, 73);
            this.NetworkSettings.Name = "NetworkSettings";
            this.NetworkSettings.Size = new System.Drawing.Size(269, 323);
            this.NetworkSettings.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Application Port:";
            // 
            // IPA
            // 
            this.IPA.AutoSize = true;
            this.IPA.Location = new System.Drawing.Point(0, 0);
            this.IPA.Name = "IPA";
            this.IPA.Size = new System.Drawing.Size(61, 13);
            this.IPA.TabIndex = 2;
            this.IPA.Text = "IP Address:";
            // 
            // IPPort
            // 
            this.IPPort.Location = new System.Drawing.Point(0, 55);
            this.IPPort.Name = "IPPort";
            this.IPPort.Size = new System.Drawing.Size(100, 20);
            this.IPPort.TabIndex = 1;
            this.IPPort.TextChanged += new System.EventHandler(this.IPPort_TextChanged);
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(0, 16);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(100, 20);
            this.IPAddress.TabIndex = 0;
            this.IPAddress.TextChanged += new System.EventHandler(this.IPAddress_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(452, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(16, 19);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(469, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Apply";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SaveSettings);
            // 
            // instSettings
            // 
            this.instSettings.Controls.Add(this.label5);
            this.instSettings.Controls.Add(this.label4);
            this.instSettings.Controls.Add(this.label2);
            this.instSettings.Controls.Add(this.label3);
            this.instSettings.Controls.Add(this.MinRam);
            this.instSettings.Controls.Add(this.MaxRam);
            this.instSettings.Location = new System.Drawing.Point(469, 73);
            this.instSettings.Name = "instSettings";
            this.instSettings.Size = new System.Drawing.Size(269, 323);
            this.instSettings.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "MB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimal RAM utilization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximal RAM utilization";
            // 
            // MinRam
            // 
            this.MinRam.Location = new System.Drawing.Point(0, 55);
            this.MinRam.Name = "MinRam";
            this.MinRam.Size = new System.Drawing.Size(56, 20);
            this.MinRam.TabIndex = 1;
            this.MinRam.TextChanged += new System.EventHandler(this.MinRam_TextChanged);
            // 
            // MaxRam
            // 
            this.MaxRam.Location = new System.Drawing.Point(0, 16);
            this.MaxRam.Name = "MaxRam";
            this.MaxRam.Size = new System.Drawing.Size(56, 20);
            this.MaxRam.TabIndex = 0;
            this.MaxRam.TextChanged += new System.EventHandler(this.MaxRam_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(708, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "->";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(469, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "<-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ServerSettings
            // 
            this.ServerSettings.Controls.Add(this.enablecommandblocks);
            this.ServerSettings.Controls.Add(this.label11);
            this.ServerSettings.Controls.Add(this.allowflight);
            this.ServerSettings.Controls.Add(this.label10);
            this.ServerSettings.Controls.Add(this.difficultyCombo);
            this.ServerSettings.Controls.Add(this.label9);
            this.ServerSettings.Controls.Add(this.PVP);
            this.ServerSettings.Controls.Add(this.label8);
            this.ServerSettings.Controls.Add(this.label6);
            this.ServerSettings.Controls.Add(this.MaxPlayer);
            this.ServerSettings.Controls.Add(this.OnlineMode);
            this.ServerSettings.Controls.Add(this.label7);
            this.ServerSettings.Location = new System.Drawing.Point(469, 73);
            this.ServerSettings.Name = "ServerSettings";
            this.ServerSettings.Size = new System.Drawing.Size(269, 323);
            this.ServerSettings.TabIndex = 5;
            // 
            // enablecommandblocks
            // 
            this.enablecommandblocks.FormattingEnabled = true;
            this.enablecommandblocks.Items.AddRange(new object[] {
            "true",
            "false"});
            this.enablecommandblocks.Location = new System.Drawing.Point(2, 213);
            this.enablecommandblocks.Name = "enablecommandblocks";
            this.enablecommandblocks.Size = new System.Drawing.Size(79, 21);
            this.enablecommandblocks.TabIndex = 13;
            this.enablecommandblocks.SelectedIndexChanged += new System.EventHandler(this.Enablecommandblocks_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-1, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Enable Command Blocks";
            // 
            // allowflight
            // 
            this.allowflight.FormattingEnabled = true;
            this.allowflight.Items.AddRange(new object[] {
            "true",
            "false"});
            this.allowflight.Location = new System.Drawing.Point(2, 173);
            this.allowflight.Name = "allowflight";
            this.allowflight.Size = new System.Drawing.Size(79, 21);
            this.allowflight.TabIndex = 11;
            this.allowflight.SelectedIndexChanged += new System.EventHandler(this.Allowflight_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Allow-flight";
            // 
            // difficultyCombo
            // 
            this.difficultyCombo.FormattingEnabled = true;
            this.difficultyCombo.Items.AddRange(new object[] {
            "Peaceful",
            "Easy",
            "Normal",
            "Hard"});
            this.difficultyCombo.Location = new System.Drawing.Point(2, 133);
            this.difficultyCombo.Name = "difficultyCombo";
            this.difficultyCombo.Size = new System.Drawing.Size(79, 21);
            this.difficultyCombo.TabIndex = 9;
            this.difficultyCombo.SelectedIndexChanged += new System.EventHandler(this.DifficultyCombo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Difficulty";
            // 
            // PVP
            // 
            this.PVP.FormattingEnabled = true;
            this.PVP.Items.AddRange(new object[] {
            "true",
            "false"});
            this.PVP.Location = new System.Drawing.Point(2, 94);
            this.PVP.Name = "PVP";
            this.PVP.Size = new System.Drawing.Size(79, 21);
            this.PVP.TabIndex = 7;
            this.PVP.SelectedIndexChanged += new System.EventHandler(this.PVP_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "PVP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max Player Limit:";
            // 
            // MaxPlayer
            // 
            this.MaxPlayer.Location = new System.Drawing.Point(2, 55);
            this.MaxPlayer.Name = "MaxPlayer";
            this.MaxPlayer.Size = new System.Drawing.Size(100, 20);
            this.MaxPlayer.TabIndex = 4;
            this.MaxPlayer.TextChanged += new System.EventHandler(this.MaxPlayer_TextChanged);
            // 
            // OnlineMode
            // 
            this.OnlineMode.FormattingEnabled = true;
            this.OnlineMode.Items.AddRange(new object[] {
            "true",
            "false"});
            this.OnlineMode.Location = new System.Drawing.Point(2, 16);
            this.OnlineMode.Name = "OnlineMode";
            this.OnlineMode.Size = new System.Drawing.Size(79, 21);
            this.OnlineMode.TabIndex = 3;
            this.OnlineMode.SelectedIndexChanged += new System.EventHandler(this.OnlineMode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Online mode:";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Calibri", 14F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(34, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 23);
            this.Title.TabIndex = 10;
            this.Title.Text = "Test text";
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(628, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 28);
            this.button10.TabIndex = 13;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(689, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 28);
            this.button7.TabIndex = 11;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseEnter += new System.EventHandler(this.button7_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.iconA);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 28);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(749, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 522);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 522);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 431);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(768, 32);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // mods
            // 
            this.mods.Controls.Add(this.button8);
            this.mods.Controls.Add(this.listView1);
            this.mods.Location = new System.Drawing.Point(469, 73);
            this.mods.Name = "mods";
            this.mods.Size = new System.Drawing.Size(269, 323);
            this.mods.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(177, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Enable/Disable";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(269, 284);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListView1_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Version";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 61;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(642, 400);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "Open Directory";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(768, 1);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // iconA
            // 
            this.iconA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iconA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconA.BackgroundImage")));
            this.iconA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconA.Location = new System.Drawing.Point(0, 0);
            this.iconA.Name = "iconA";
            this.iconA.Size = new System.Drawing.Size(28, 28);
            this.iconA.TabIndex = 13;
            this.iconA.TabStop = false;
            // 
            // InstanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(750, 432);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ServerSettings);
            this.Controls.Add(this.NetworkSettings);
            this.Controls.Add(this.mods);
            this.Controls.Add(this.instSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstanceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstanceWindow";
            this.Activated += new System.EventHandler(this.InstanceWindow_Activated);
            this.Deactivate += new System.EventHandler(this.InstanceWindow_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstanceWindow_FormClosing);
            this.Load += new System.EventHandler(this.InstanceWindow_Load);
            this.NetworkSettings.ResumeLayout(false);
            this.NetworkSettings.PerformLayout();
            this.instSettings.ResumeLayout(false);
            this.instSettings.PerformLayout();
            this.ServerSettings.ResumeLayout(false);
            this.ServerSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel NetworkSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IPA;
        private System.Windows.Forms.TextBox IPPort;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel instSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinRam;
        private System.Windows.Forms.TextBox MaxRam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel ServerSettings;
        private System.Windows.Forms.ComboBox OnlineMode;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel mods;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaxPlayer;
        private System.Windows.Forms.ComboBox PVP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox difficultyCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox allowflight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox enablecommandblocks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox iconA;
    }
}