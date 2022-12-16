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
            lblResult.Text = "";
            int dan = int.Parse(tbDan.Text);
            for (int i = 1; i < 10; i++)
            {
                lblResult.Text += dan.ToString() + " * " + i.ToString() + " = " + (dan * i).ToString() +
                                  Environment.NewLine;
            }
        }

        private void tbDan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnResult_Click(this, EventArgs.Empty);
            }
        }
    }
}