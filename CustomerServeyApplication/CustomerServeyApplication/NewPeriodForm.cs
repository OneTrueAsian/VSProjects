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
    public partial class NewPeriodForm : Form
    {
        public NewPeriodForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void SubmitFolder_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerEntryForm cForm = new CustomerEntryForm();
            cForm.ShowDialog();
            this.Close();
        }
    }
}
