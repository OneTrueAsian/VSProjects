namespace CalclManager
{
    partial class OpeningForm
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
            this.ChoiceBox = new System.Windows.Forms.ComboBox();
            this.SelectCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChoiceBox
            // 
            this.ChoiceBox.FormattingEnabled = true;
            this.ChoiceBox.Location = new System.Drawing.Point(64, 73);
            this.ChoiceBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChoiceBox.Name = "ChoiceBox";
            this.ChoiceBox.Size = new System.Drawing.Size(195, 24);
            this.ChoiceBox.TabIndex = 1;
            // 
            // SelectCalc
            // 
            this.SelectCalc.Location = new System.Drawing.Point(114, 105);
            this.SelectCalc.Margin = new System.Windows.Forms.Padding(4);
            this.SelectCalc.Name = "SelectCalc";
            this.SelectCalc.Size = new System.Drawing.Size(100, 28);
            this.SelectCalc.TabIndex = 2;
            this.SelectCalc.Text = "Select";
            this.SelectCalc.UseVisualStyleBackColor = true;
            this.SelectCalc.Click += new System.EventHandler(this.SelectCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Calculator Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectCalc);
            this.Controls.Add(this.ChoiceBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ChoiceBox;
        private System.Windows.Forms.Button SelectCalc;
        private System.Windows.Forms.Label label1;
    }
}

