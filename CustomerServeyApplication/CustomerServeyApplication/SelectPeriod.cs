using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerServeyApplication
{
    public partial class SelectPeriod : Form
    {
        public string iFolder;

        public SelectPeriod()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //Button for calling new Period Form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPeriodForm formP = new NewPeriodForm();
            formP.ShowDialog();
            this.Close();
        }

        // Button for calling a new Customer Entry Form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerEntryForm cForm = new CustomerEntryForm();
            cForm.ShowDialog();
            this.Close();
        }

        // Select file Button
        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            iFolder = folderBrowserDialog1.SelectedPath;

            string[] files = Directory.GetFiles(iFolder);
            int i; // Index of last file path "\" character
            string f; // File name

            foreach (string fname in files)
            {
                i = fname.LastIndexOf('\\') + 1;
                f = fname.Substring(i);
                if (f.EndsWith(".xlsx"))
                {
                    FileSelect.Items.Add(f);
                    if (FileSelect == null)
                    {
                        throw new System.ArgumentNullException("Please Select A File");
                    }
                }
            }
        }

        public string getFile()
        {
            return FileSelect.ToString();
        }
    }
}
