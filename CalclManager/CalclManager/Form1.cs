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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectCalc_Click(object sender, EventArgs e)
        {
            ChoiceBox.Items.Add("Contribution Income Statement");
            ChoiceBox.Items.Add("Tradition Income Statement");
            // ChoiceBox.Items.Add("");

            String choice = ChoiceBox.Text;

            switch (choice)
            {
                case "Contribution Income Statement":
                    Form formc = new ContributionFrom();
                    break;
                case "Tradition Income Statement":
                    Form formTraditional = new TraditionalFrom();
                    break;
            }
        }
    }
}
