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
    public partial class CustomerEntryForm : Form
    {
        public CustomerEntryForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        // Moves on to the next from
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionForm qForm = new QuestionForm();
            qForm.ShowDialog();
            this.Close();
        }

        public void WriteData()
        {
            SelectPeriod sp = new SelectPeriod();
            /** 
             * Todo: make the file selectable
             *  Todo: data = comboBox entry
             *  Todo: row and col set numbers
             *  Todo: if cell has value -> ++ row and column to next cell
             * **/

            // Opens the excel book
            Excel excel = new Excel(@sp.getFile(), 1);

            // excel.WriteToCell(row, column, data)
            excel.WriteToCell(0, 0, "qOneBox");
            excel.SaveFile();
            excel.SaveAs(@"Test2.xlsx");
            excel.Close();
        }
    }
}
