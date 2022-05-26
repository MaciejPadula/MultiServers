namespace MultiServers.InstanceUI
{
    partial class CreateInstance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateInstance));
            this.serverName = new System.Windows.Forms.TextBox();
            this.serverVersion = new System.Windows.Forms.Button();
            this.createServer = new System.Windows.Forms.Button();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.versionListView = new System.Windows.Forms.ListView();
            this.versionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadProgressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(12, 30);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(138, 20);
            this.serverName.TabIndex = 0;
            this.serverName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serverVersion
            // 
            this.serverVersion.Location = new System.Drawing.Point(40, 57);
            this.serverVersion.Name = "serverVersion";
            this.serverVersion.Size = new System.Drawing.Size(75, 23);
            this.serverVersion.TabIndex = 1;
            this.serverVersion.Tag = "https://launchermeta.mojang.com/v1/packages/5158765caf1ca14958cb6c45d52c8e09ed9b0" +
    "46c/1.2.5.json";
            this.serverVersion.Text = "1.2.5";
            this.serverVersion.UseVisualStyleBackColor = true;
            this.serverVersion.Click += new System.EventHandler(this.serverVersion_Click);
            // 
            // createServer
            // 
            this.createServer.Location = new System.Drawing.Point(40, 99);
            this.createServer.Name = "createServer";
            this.createServer.Size = new System.Drawing.Size(75, 23);
            this.createServer.TabIndex = 2;
            this.createServer.Text = "Create";
            this.createServer.UseVisualStyleBackColor = true;
            this.createServer.Click += new System.EventHandler(this.createServer_Click);
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(12, 135);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(138, 23);
            this.downloadProgressBar.TabIndex = 3;
            this.downloadProgressBar.Visible = false;
            // 
            // versionListView
            // 
            this.versionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.versionColumn,
            this.releaseTypeColumn});
            this.versionListView.HideSelection = false;
            this.versionListView.Location = new System.Drawing.Point(164, 12);
            this.versionListView.Name = "versionListView";
            this.versionListView.Size = new System.Drawing.Size(189, 159);
            this.versionListView.TabIndex = 4;
            this.versionListView.UseCompatibleStateImageBehavior = false;
            this.versionListView.View = System.Windows.Forms.View.Details;
            // 
            // versionColumn
            // 
            this.versionColumn.Text = "Version";
            this.versionColumn.Width = 71;
            // 
            // releaseTypeColumn
            // 
            this.releaseTypeColumn.Text = "Release Type";
            this.releaseTypeColumn.Width = 88;
            // 
            // downloadProgressLabel
            // 
            this.downloadProgressLabel.Location = new System.Drawing.Point(12, 161);
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            this.downloadProgressLabel.Size = new System.Drawing.Size(138, 23);
            this.downloadProgressLabel.TabIndex = 5;
            this.downloadProgressLabel.Text = "100%";
            this.downloadProgressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Instance Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downloadProgressLabel);
            this.Controls.Add(this.versionListView);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.createServer);
            this.Controls.Add(this.serverVersion);
            this.Controls.Add(this.serverName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Instance";
            this.Load += new System.EventHandler(this.CreateInstance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Button serverVersion;
        private System.Windows.Forms.Button createServer;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.ListView versionListView;
        private System.Windows.Forms.ColumnHeader versionColumn;
        private System.Windows.Forms.ColumnHeader releaseTypeColumn;
        private System.Windows.Forms.Label downloadProgressLabel;
        private System.Windows.Forms.Label label2;
    }
}