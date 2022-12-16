using System;
using System.Windows.Forms;

namespace loop_20221216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            var i = 0;
            while (i < 5)
            {
                lblResult.Text += "Programming\n";
                i++;
            }
        }
    }
}