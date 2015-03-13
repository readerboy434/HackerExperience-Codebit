namespace HackerExperienceHelper
{
    partial class MainForm
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
            this.IPListBox = new System.Windows.Forms.ListBox();
            this.IPsLabel = new System.Windows.Forms.Label();
            this.BanksListBox = new System.Windows.Forms.ListBox();
            this.BanksLabel = new System.Windows.Forms.Label();
            this.BTCListBox = new System.Windows.Forms.ListBox();
            this.BTCLabel = new System.Windows.Forms.Label();
            this.NewIP = new System.Windows.Forms.Button();
            this.NewBank = new System.Windows.Forms.Button();
            this.NewBTC = new System.Windows.Forms.Button();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPListBox
            // 
            this.IPListBox.FormattingEnabled = true;
            this.IPListBox.Location = new System.Drawing.Point(295, 24);
            this.IPListBox.Name = "IPListBox";
            this.IPListBox.Size = new System.Drawing.Size(181, 602);
            this.IPListBox.TabIndex = 1;
            // 
            // IPsLabel
            // 
            this.IPsLabel.AutoSize = true;
            this.IPsLabel.Location = new System.Drawing.Point(295, 8);
            this.IPsLabel.Name = "IPsLabel";
            this.IPsLabel.Size = new System.Drawing.Size(22, 13);
            this.IPsLabel.TabIndex = 2;
            this.IPsLabel.Text = "IPs";
            // 
            // BanksListBox
            // 
            this.BanksListBox.FormattingEnabled = true;
            this.BanksListBox.Location = new System.Drawing.Point(482, 24);
            this.BanksListBox.Name = "BanksListBox";
            this.BanksListBox.Size = new System.Drawing.Size(181, 602);
            this.BanksListBox.TabIndex = 3;
            // 
            // BanksLabel
            // 
            this.BanksLabel.AutoSize = true;
            this.BanksLabel.Location = new System.Drawing.Point(479, 8);
            this.BanksLabel.Name = "BanksLabel";
            this.BanksLabel.Size = new System.Drawing.Size(145, 13);
            this.BanksLabel.TabIndex = 4;
            this.BanksLabel.Text = "Bank Accounts - Bank Name";
            // 
            // BTCListBox
            // 
            this.BTCListBox.FormattingEnabled = true;
            this.BTCListBox.Location = new System.Drawing.Point(669, 24);
            this.BTCListBox.Name = "BTCListBox";
            this.BTCListBox.Size = new System.Drawing.Size(181, 602);
            this.BTCListBox.TabIndex = 5;
            // 
            // BTCLabel
            // 
            this.BTCLabel.AutoSize = true;
            this.BTCLabel.Location = new System.Drawing.Point(666, 8);
            this.BTCLabel.Name = "BTCLabel";
            this.BTCLabel.Size = new System.Drawing.Size(93, 13);
            this.BTCLabel.TabIndex = 6;
            this.BTCLabel.Text = "BTC Public:Pivate";
            // 
            // NewIP
            // 
            this.NewIP.Location = new System.Drawing.Point(12, 389);
            this.NewIP.Name = "NewIP";
            this.NewIP.Size = new System.Drawing.Size(277, 75);
            this.NewIP.TabIndex = 7;
            this.NewIP.Text = "New IP";
            this.NewIP.UseVisualStyleBackColor = true;
            this.NewIP.Click += new System.EventHandler(this.NewIP_Click);
            // 
            // NewBank
            // 
            this.NewBank.Location = new System.Drawing.Point(12, 470);
            this.NewBank.Name = "NewBank";
            this.NewBank.Size = new System.Drawing.Size(277, 75);
            this.NewBank.TabIndex = 8;
            this.NewBank.Text = "New Bank Account";
            this.NewBank.UseVisualStyleBackColor = true;
            this.NewBank.Click += new System.EventHandler(this.NewBank_Click);
            // 
            // NewBTC
            // 
            this.NewBTC.Location = new System.Drawing.Point(12, 551);
            this.NewBTC.Name = "NewBTC";
            this.NewBTC.Size = new System.Drawing.Size(277, 75);
            this.NewBTC.TabIndex = 9;
            this.NewBTC.Text = "New Bitcoin Address";
            this.NewBTC.UseVisualStyleBackColor = true;
            this.NewBTC.Click += new System.EventHandler(this.NewBTC_Click);
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(12, 24);
            this.NotesBox.Multiline = true;
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(277, 359);
            this.NotesBox.TabIndex = 10;
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(12, 8);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(35, 13);
            this.NotesLabel.TabIndex = 11;
            this.NotesLabel.Text = "Notes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 640);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.NewBTC);
            this.Controls.Add(this.NewBank);
            this.Controls.Add(this.NewIP);
            this.Controls.Add(this.BTCLabel);
            this.Controls.Add(this.BTCListBox);
            this.Controls.Add(this.BanksLabel);
            this.Controls.Add(this.BanksListBox);
            this.Controls.Add(this.IPsLabel);
            this.Controls.Add(this.IPListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(879, 679);
            this.MinimumSize = new System.Drawing.Size(879, 679);
            this.Name = "MainForm";
            this.Text = "Hacker Experience Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox IPListBox;
        private System.Windows.Forms.Label IPsLabel;
        private System.Windows.Forms.ListBox BanksListBox;
        private System.Windows.Forms.Label BanksLabel;
        private System.Windows.Forms.ListBox BTCListBox;
        private System.Windows.Forms.Label BTCLabel;
        private System.Windows.Forms.Button NewIP;
        private System.Windows.Forms.Button NewBank;
        private System.Windows.Forms.Button NewBTC;
        private System.Windows.Forms.TextBox NotesBox;
        private System.Windows.Forms.Label NotesLabel;

    }
}

