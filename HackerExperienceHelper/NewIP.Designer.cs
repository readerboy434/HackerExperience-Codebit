namespace HackerExperienceHelper
{
    partial class NewIP
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
            this.IPLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(12, 9);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(20, 13);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(144, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(403, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // NewIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 33);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IPLabel);
            this.MaximumSize = new System.Drawing.Size(505, 72);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(505, 72);
            this.Name = "NewIP";
            this.Text = "New IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddButton;
    }
}