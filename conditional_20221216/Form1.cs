using System;
using System.Windows.Forms;

namespace conditional_20221216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnResult_Click(object sender, EventArgs e)
        {
            var kuk = int.Parse(tbKuk.Text);
            var eng = int.Parse(tbEng.Text);
            var math = int.Parse(tbMath.Text);
            var total = kuk + eng + math;
            lblAvg.Text = (total / 3).ToString();
            if (total / 3 >= 90)
                lblResult.Text = "A학점";
            else if (total / 3 >= 80)
                lblResult.Text = "B학점";
            else if (total / 3 >= 70)
                lblResult.Text = "C학점";
            else if (total / 3 >= 60)
                lblResult.Text = "D학점";
            else
                lblResult.Text = "F학점";
        }

        private void tbKuk_Enter(object sender, EventArgs e)
        {
            tbKuk.Text = "";
        }

        private void tbEng_Enter(object sender, EventArgs e)
        {
            tbEng.Text = "";
        }

        private void tbMath_Enter(object sender, EventArgs e)
        {
            tbMath.Text = "";
        }
    }
}