using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalclManager
{
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();

             ChoiceBox.Items.Add("Contribution Income Statement");
            ChoiceBox.Items.Add("Tradition Income Statement");
            // ChoiceBox.Items.Add("");
            //this.Close();
        }

        private void SelectCalc_Click(object sender, EventArgs e)
        {
            //String choice = ChoiceBox.Text;

            if (ChoiceBox.Text == "Contribution Income Statement")
            {
                Form ContributionFrom = new ContributionFrom();
                ContributionFrom.Show();
            } else{
                Form TraditionalFrom = new TraditionalFrom();
                TraditionalFrom.Show();
            }

        }

    }
}
