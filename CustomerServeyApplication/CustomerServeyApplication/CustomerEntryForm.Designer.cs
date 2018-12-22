namespace CustomerServeyApplication
{
    partial class CustomerEntryForm
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
            this.CLabel = new System.Windows.Forms.Label();
            this.LocLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.NameEntry = new System.Windows.Forms.TextBox();
            this.LocEntry = new System.Windows.Forms.TextBox();
            this.RoleEntry = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(12, 9);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(38, 13);
            this.CLabel.TabIndex = 0;
            this.CLabel.Text = "Name:";
            // 
            // LocLabel
            // 
            this.LocLabel.AutoSize = true;
            this.LocLabel.Location = new System.Drawing.Point(12, 39);
            this.LocLabel.Name = "LocLabel";
            this.LocLabel.Size = new System.Drawing.Size(51, 13);
            this.LocLabel.TabIndex = 1;
            this.LocLabel.Text = "Location:";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(12, 64);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(32, 13);
            this.RLabel.TabIndex = 2;
            this.RLabel.Text = "Role:";
            // 
            // NameEntry
            // 
            this.NameEntry.Location = new System.Drawing.Point(65, 6);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(100, 20);
            this.NameEntry.TabIndex = 3;
            // 
            // LocEntry
            // 
            this.LocEntry.Location = new System.Drawing.Point(65, 39);
            this.LocEntry.Name = "LocEntry";
            this.LocEntry.Size = new System.Drawing.Size(100, 20);
            this.LocEntry.TabIndex = 4;
            // 
            // RoleEntry
            // 
            this.RoleEntry.Location = new System.Drawing.Point(65, 66);
            this.RoleEntry.Name = "RoleEntry";
            this.RoleEntry.Size = new System.Drawing.Size(100, 20);
            this.RoleEntry.TabIndex = 5;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(90, 102);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CustomerEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 128);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RoleEntry);
            this.Controls.Add(this.LocEntry);
            this.Controls.Add(this.NameEntry);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.LocLabel);
            this.Controls.Add(this.CLabel);
            this.Name = "CustomerEntryForm";
            this.Text = "Name Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label LocLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.TextBox NameEntry;
        private System.Windows.Forms.TextBox LocEntry;
        private System.Windows.Forms.TextBox RoleEntry;
        private System.Windows.Forms.Button NextButton;
    }
}