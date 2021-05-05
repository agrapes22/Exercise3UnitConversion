using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3UnitConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(lbsBox.Text))
            {
                double lbsInt = double.Parse(lbsBox.Text);
                double toKilo = lbsInt * 0.453592;
                string kiloString = toKilo.ToString();
                kiloBox.Text = kiloString;
            }
        }
    }
}
