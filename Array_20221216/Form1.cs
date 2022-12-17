using System;
using System.Windows.Forms;

namespace Array_20221216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array = new int[] { 0, 0, 0 };

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblResult.Text = "배열 출력 : ";
            array[0] = int.Parse(tbInput1.Text);
            array[1] = int.Parse(tbInput2.Text);
            array[2] = int.Parse(tbInput3.Text);
            for (int i = 0; i < 3; i++)
            {
                lblResult.Text += array[i].ToString() + "  ";
            }
        }
    }
}