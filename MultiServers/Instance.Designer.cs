namespace MultiServers
{
    partial class Instance
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instance));
            this.NameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxRamLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MinRamLabel = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.InstanceFolderButton = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Location = new System.Drawing.Point(167, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 26);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // VersionLabel
            // 
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Location = new System.Drawing.Point(286, 35);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(66, 26);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(167, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(286, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Version";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(369, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "MaxRam:";
            // 
            // MaxRamLabel
            // 
            this.MaxRamLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxRamLabel.Location = new System.Drawing.Point(369, 35);
            this.MaxRamLabel.Name = "MaxRamLabel";
            this.MaxRamLabel.Size = new System.Drawing.Size(89, 26);
            this.MaxRamLabel.TabIndex = 4;
            this.MaxRamLabel.Text = "Version";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(464, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "MinRam:";
            // 
            // MinRamLabel
            // 
            this.MinRamLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinRamLabel.Location = new System.Drawing.Point(464, 35);
            this.MinRamLabel.Name = "MinRamLabel";
            this.MinRamLabel.Size = new System.Drawing.Size(89, 26);
            this.MinRamLabel.TabIndex = 6;
            this.MinRamLabel.Text = "Version";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(608, 67);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(65, 23);
            this.remove.TabIndex = 8;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenButton.Location = new System.Drawing.Point(598, 11);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 50);
            this.OpenButton.TabIndex = 9;
            this.OpenButton.Text = "->";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // InstanceFolderButton
            // 
            this.InstanceFolderButton.Location = new System.Drawing.Point(170, 64);
            this.InstanceFolderButton.Name = "InstanceFolderButton";
            this.InstanceFolderButton.Size = new System.Drawing.Size(126, 23);
            this.InstanceFolderButton.TabIndex = 10;
            this.InstanceFolderButton.Text = "Open Instance Folder";
            this.InstanceFolderButton.UseVisualStyleBackColor = true;
            this.InstanceFolderButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // background
            // 
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(161, 90);
            this.background.TabIndex = 11;
            this.background.TabStop = false;
            // 
            // Instance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.background);
            this.Controls.Add(this.InstanceFolderButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinRamLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxRamLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Instance";
            this.Size = new System.Drawing.Size(673, 90);
            this.MouseEnter += new System.EventHandler(this.Instance_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Instance_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Label VersionLabel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label MaxRamLabel;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label MinRamLabel;
        private System.Windows.Forms.Button remove;
        public System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button InstanceFolderButton;
        public System.Windows.Forms.PictureBox background;
    }
}
