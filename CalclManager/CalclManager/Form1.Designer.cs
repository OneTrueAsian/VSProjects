namespace CalclManager
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChoiceBox = new System.Windows.Forms.ComboBox();
            this.SelectCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Select Calculator Type";
            // 
            // ChoiceBox
            // 
            this.ChoiceBox.FormattingEnabled = true;
            this.ChoiceBox.Location = new System.Drawing.Point(48, 59);
            this.ChoiceBox.Name = "ChoiceBox";
            this.ChoiceBox.Size = new System.Drawing.Size(118, 21);
            this.ChoiceBox.TabIndex = 1;
            // 
            // SelectCalc
            // 
            this.SelectCalc.Location = new System.Drawing.Point(65, 86);
            this.SelectCalc.Name = "SelectCalc";
            this.SelectCalc.Size = new System.Drawing.Size(75, 23);
            this.SelectCalc.TabIndex = 2;
            this.SelectCalc.Text = "Select";
            this.SelectCalc.UseVisualStyleBackColor = true;
            this.SelectCalc.Click += new System.EventHandler(this.SelectCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 146);
            this.Controls.Add(this.SelectCalc);
            this.Controls.Add(this.ChoiceBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ChoiceBox;
        private System.Windows.Forms.Button SelectCalc;
    }
}

