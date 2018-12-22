using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomerServeyApplication
{
    public partial class QuestionForm : Form
    {
        string path;
        public QuestionForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // adds another Customer entry form
        private void AddButton_Click(object sender, EventArgs e)
        {
            WriteData();

            this.Hide();
            CustomerEntryForm cForm = new CustomerEntryForm();
            cForm.ShowDialog();
            this.Close();

        }

        public void WriteData()
        {

            /** 
             * Todo: make the file selectable
             *  Todo: data = comboBox entry
             *  Todo: row and col set numbers
             *  Todo: if cell has value -> ++ row and column to next cell
             * **/

            // Opens the excel book
            Excel excel = new Excel(@"",1);
            // excel.WriteToCell(row, column, data)
            excel.WriteToCell(0, 0, "qOneBox");
            excel.SaveFile();
            excel.SaveAs(@"Test2.xlsx");
            excel.Close();
        }
    }
}
