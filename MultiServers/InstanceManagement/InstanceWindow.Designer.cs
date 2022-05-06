namespace MultiServers.InstanceManagement
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
            this.serverConsole = new System.Windows.Forms.RichTextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.NetworkSettings = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IPA = new System.Windows.Forms.Label();
            this.serverPortTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.jarFileComboBox = new System.Windows.Forms.ComboBox();
            this.enter = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.instSettings = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minRam = new System.Windows.Forms.TextBox();
            this.maxRam = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.ServerSettings = new System.Windows.Forms.Panel();
            this.enableCommandBlocksComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.allowFlightComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pvpComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxPlayersTextBox = new System.Windows.Forms.TextBox();
            this.onlineModeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Minim = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconA = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mods = new System.Windows.Forms.Panel();
            this.enableDisableMod = new System.Windows.Forms.Button();
            this.modsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operDirButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.NetworkSettings.SuspendLayout();
            this.instSettings.SuspendLayout();
            this.ServerSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // serverConsole
            // 
            this.serverConsole.BackColor = System.Drawing.SystemColors.Desktop;
            this.serverConsole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.serverConsole.Location = new System.Drawing.Point(12, 73);
            this.serverConsole.Name = "serverConsole";
            this.serverConsole.ReadOnly = true;
            this.serverConsole.Size = new System.Drawing.Size(434, 323);
            this.serverConsole.TabIndex = 0;
            this.serverConsole.Text = "";
            this.serverConsole.TextChanged += new System.EventHandler(this.serverConsole_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(11, 44);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.run_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(102, 44);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stop_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputTextBox.Location = new System.Drawing.Point(13, 402);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(433, 20);
            this.inputTextBox.TabIndex = 3;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // NetworkSettings
            // 
            this.NetworkSettings.Controls.Add(this.label1);
            this.NetworkSettings.Controls.Add(this.IPA);
            this.NetworkSettings.Controls.Add(this.serverPortTextBox);
            this.NetworkSettings.Controls.Add(this.ipAddressTextBox);
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
            // serverPortTextBox
            // 
            this.serverPortTextBox.Location = new System.Drawing.Point(0, 55);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.serverPortTextBox.TabIndex = 1;
            this.serverPortTextBox.TextChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(0, 16);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipAddressTextBox.TabIndex = 0;
            this.ipAddressTextBox.TextChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // jarFileComboBox
            // 
            this.jarFileComboBox.FormattingEnabled = true;
            this.jarFileComboBox.Location = new System.Drawing.Point(183, 46);
            this.jarFileComboBox.Name = "jarFileComboBox";
            this.jarFileComboBox.Size = new System.Drawing.Size(121, 21);
            this.jarFileComboBox.TabIndex = 5;
            this.jarFileComboBox.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(452, 403);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(16, 19);
            this.enter.TabIndex = 6;
            this.enter.Text = "button3";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(469, 400);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.saveSettings);
            // 
            // instSettings
            // 
            this.instSettings.Controls.Add(this.label5);
            this.instSettings.Controls.Add(this.label4);
            this.instSettings.Controls.Add(this.label2);
            this.instSettings.Controls.Add(this.label3);
            this.instSettings.Controls.Add(this.minRam);
            this.instSettings.Controls.Add(this.maxRam);
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
            // minRam
            // 
            this.minRam.Location = new System.Drawing.Point(0, 55);
            this.minRam.Name = "minRam";
            this.minRam.Size = new System.Drawing.Size(56, 20);
            this.minRam.TabIndex = 1;
            this.minRam.TextChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // maxRam
            // 
            this.maxRam.Location = new System.Drawing.Point(0, 16);
            this.maxRam.Name = "maxRam";
            this.maxRam.Size = new System.Drawing.Size(56, 20);
            this.maxRam.TabIndex = 0;
            this.maxRam.TextChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(708, 44);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(30, 23);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "->";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.next_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(469, 44);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(30, 23);
            this.prevButton.TabIndex = 9;
            this.prevButton.Text = "<-";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prev_Click);
            // 
            // ServerSettings
            // 
            this.ServerSettings.Controls.Add(this.enableCommandBlocksComboBox);
            this.ServerSettings.Controls.Add(this.label11);
            this.ServerSettings.Controls.Add(this.allowFlightComboBox);
            this.ServerSettings.Controls.Add(this.label10);
            this.ServerSettings.Controls.Add(this.difficultyComboBox);
            this.ServerSettings.Controls.Add(this.label9);
            this.ServerSettings.Controls.Add(this.pvpComboBox);
            this.ServerSettings.Controls.Add(this.label8);
            this.ServerSettings.Controls.Add(this.label6);
            this.ServerSettings.Controls.Add(this.maxPlayersTextBox);
            this.ServerSettings.Controls.Add(this.onlineModeComboBox);
            this.ServerSettings.Controls.Add(this.label7);
            this.ServerSettings.Location = new System.Drawing.Point(469, 73);
            this.ServerSettings.Name = "ServerSettings";
            this.ServerSettings.Size = new System.Drawing.Size(269, 323);
            this.ServerSettings.TabIndex = 5;
            // 
            // enableCommandBlocksComboBox
            // 
            this.enableCommandBlocksComboBox.FormattingEnabled = true;
            this.enableCommandBlocksComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.enableCommandBlocksComboBox.Location = new System.Drawing.Point(2, 213);
            this.enableCommandBlocksComboBox.Name = "enableCommandBlocksComboBox";
            this.enableCommandBlocksComboBox.Size = new System.Drawing.Size(79, 21);
            this.enableCommandBlocksComboBox.TabIndex = 13;
            this.enableCommandBlocksComboBox.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
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
            // allowFlightComboBox
            // 
            this.allowFlightComboBox.FormattingEnabled = true;
            this.allowFlightComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.allowFlightComboBox.Location = new System.Drawing.Point(2, 173);
            this.allowFlightComboBox.Name = "allowFlightComboBox";
            this.allowFlightComboBox.Size = new System.Drawing.Size(79, 21);
            this.allowFlightComboBox.TabIndex = 11;
            this.allowFlightComboBox.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
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
            // difficultyComboBox
            // 
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Items.AddRange(new object[] {
            "Peaceful",
            "Easy",
            "Normal",
            "Hard"});
            this.difficultyComboBox.Location = new System.Drawing.Point(2, 133);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(79, 21);
            this.difficultyComboBox.TabIndex = 9;
            this.difficultyComboBox.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
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
            // pvpComboBox
            // 
            this.pvpComboBox.FormattingEnabled = true;
            this.pvpComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.pvpComboBox.Location = new System.Drawing.Point(2, 94);
            this.pvpComboBox.Name = "pvpComboBox";
            this.pvpComboBox.Size = new System.Drawing.Size(79, 21);
            this.pvpComboBox.TabIndex = 7;
            this.pvpComboBox.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
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
            // maxPlayersTextBox
            // 
            this.maxPlayersTextBox.Location = new System.Drawing.Point(2, 55);
            this.maxPlayersTextBox.Name = "maxPlayersTextBox";
            this.maxPlayersTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxPlayersTextBox.TabIndex = 4;
            this.maxPlayersTextBox.TextChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // onlineModeComboBox
            // 
            this.onlineModeComboBox.FormattingEnabled = true;
            this.onlineModeComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.onlineModeComboBox.Location = new System.Drawing.Point(2, 16);
            this.onlineModeComboBox.Name = "onlineModeComboBox";
            this.onlineModeComboBox.Size = new System.Drawing.Size(79, 21);
            this.onlineModeComboBox.TabIndex = 3;
            this.onlineModeComboBox.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
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
            this.Title.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Calibri", 14F);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(34, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 23);
            this.Title.TabIndex = 10;
            this.Title.Text = "Test text";
            this.Title.TextChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // Minim
            // 
            this.Minim.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Minim.FlatAppearance.BorderSize = 0;
            this.Minim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Minim.Location = new System.Drawing.Point(628, 0);
            this.Minim.Name = "Minim";
            this.Minim.Size = new System.Drawing.Size(61, 28);
            this.Minim.TabIndex = 13;
            this.Minim.Text = "-";
            this.Minim.UseVisualStyleBackColor = false;
            this.Minim.Click += new System.EventHandler(this.Minim_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Tomato;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(689, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(61, 28);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.iconA);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 28);
            this.panel1.TabIndex = 14;
            // 
            // iconA
            // 
            this.iconA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.iconA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconA.BackgroundImage")));
            this.iconA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconA.Location = new System.Drawing.Point(0, 0);
            this.iconA.Name = "iconA";
            this.iconA.Size = new System.Drawing.Size(28, 28);
            this.iconA.TabIndex = 13;
            this.iconA.TabStop = false;
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
            this.mods.Controls.Add(this.enableDisableMod);
            this.mods.Controls.Add(this.modsListView);
            this.mods.Location = new System.Drawing.Point(469, 73);
            this.mods.Name = "mods";
            this.mods.Size = new System.Drawing.Size(269, 323);
            this.mods.TabIndex = 6;
            // 
            // enableDisableMod
            // 
            this.enableDisableMod.Location = new System.Drawing.Point(177, 290);
            this.enableDisableMod.Name = "enableDisableMod";
            this.enableDisableMod.Size = new System.Drawing.Size(89, 23);
            this.enableDisableMod.TabIndex = 1;
            this.enableDisableMod.Text = "Enable/Disable";
            this.enableDisableMod.UseVisualStyleBackColor = true;
            this.enableDisableMod.Click += new System.EventHandler(this.enableDisableMod_Click);
            // 
            // modsListView
            // 
            this.modsListView.AllowDrop = true;
            this.modsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.modsListView.HideSelection = false;
            this.modsListView.Location = new System.Drawing.Point(0, 0);
            this.modsListView.Name = "modsListView";
            this.modsListView.Size = new System.Drawing.Size(269, 284);
            this.modsListView.TabIndex = 0;
            this.modsListView.UseCompatibleStateImageBehavior = false;
            this.modsListView.View = System.Windows.Forms.View.Details;
            this.modsListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.modsListView_DragDrop);
            this.modsListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.modsListView_DragEnter);
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
            // operDirButton
            // 
            this.operDirButton.Location = new System.Drawing.Point(642, 400);
            this.operDirButton.Name = "operDirButton";
            this.operDirButton.Size = new System.Drawing.Size(96, 23);
            this.operDirButton.TabIndex = 18;
            this.operDirButton.Text = "Open Directory";
            this.operDirButton.UseVisualStyleBackColor = true;
            this.operDirButton.Click += new System.EventHandler(this.openDir_Click);
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
            // InstanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(750, 432);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.operDirButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Minim);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.jarFileComboBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.serverConsole);
            this.Controls.Add(this.mods);
            this.Controls.Add(this.instSettings);
            this.Controls.Add(this.ServerSettings);
            this.Controls.Add(this.NetworkSettings);
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
            ((System.ComponentModel.ISupportInitialize)(this.iconA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox serverConsole;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Panel NetworkSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IPA;
        private System.Windows.Forms.TextBox serverPortTextBox;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.ComboBox jarFileComboBox;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Panel instSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minRam;
        private System.Windows.Forms.TextBox maxRam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Panel ServerSettings;
        private System.Windows.Forms.ComboBox onlineModeComboBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button Minim;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel mods;
        private System.Windows.Forms.ListView modsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button enableDisableMod;
        private System.Windows.Forms.Button operDirButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxPlayersTextBox;
        private System.Windows.Forms.ComboBox pvpComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox allowFlightComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox enableCommandBlocksComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox iconA;
    }
}