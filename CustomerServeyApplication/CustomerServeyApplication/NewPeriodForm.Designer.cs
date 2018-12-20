namespace CustomerServeyApplication
{
    partial class NewPeriodForm
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
            this.PeriodEntry = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PEntryBox = new System.Windows.Forms.TextBox();
            this.CYearBox = new System.Windows.Forms.TextBox();
            this.SubmitFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeriodEntry
            // 
            this.PeriodEntry.AutoSize = true;
            this.PeriodEntry.Location = new System.Drawing.Point(12, 9);
            this.PeriodEntry.Name = "PeriodEntry";
            this.PeriodEntry.Size = new System.Drawing.Size(77, 13);
            this.PeriodEntry.TabIndex = 0;
            this.PeriodEntry.Text = "Current Period:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Year:";
            // 
            // PEntryBox
            // 
            this.PEntryBox.Location = new System.Drawing.Point(95, 6);
            this.PEntryBox.Name = "PEntryBox";
            this.PEntryBox.Size = new System.Drawing.Size(100, 20);
            this.PEntryBox.TabIndex = 2;
            // 
            // CYearBox
            // 
            this.CYearBox.Location = new System.Drawing.Point(95, 34);
            this.CYearBox.Name = "CYearBox";
            this.CYearBox.Size = new System.Drawing.Size(100, 20);
            this.CYearBox.TabIndex = 3;
            // 
            // SubmitFolder
            // 
            this.SubmitFolder.Location = new System.Drawing.Point(70, 76);
            this.SubmitFolder.Name = "SubmitFolder";
            this.SubmitFolder.Size = new System.Drawing.Size(75, 23);
            this.SubmitFolder.TabIndex = 4;
            this.SubmitFolder.Text = "Submit";
            this.SubmitFolder.UseVisualStyleBackColor = true;
            // 
            // NewPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 111);
            this.Controls.Add(this.SubmitFolder);
            this.Controls.Add(this.CYearBox);
            this.Controls.Add(this.PEntryBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeriodEntry);
            this.Name = "NewPeriod";
            this.Text = "New Period Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PeriodEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PEntryBox;
        private System.Windows.Forms.TextBox CYearBox;
        private System.Windows.Forms.Button SubmitFolder;
    }
}