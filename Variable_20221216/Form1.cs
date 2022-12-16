using System;
using System.Windows.Forms;

namespace Variable_20221216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            var sValue = "잠수함이다!!";
            lbResult.Text = sValue;
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            var fValue = 3.14;
            lbResult.Text = fValue.ToString();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            var iValue = 100;
            lbResult.Text = iValue.ToString();
        }
    }
}