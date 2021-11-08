using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using operation;

namespace ControlTest_final
{
    public partial class 사칙연산 : Form
    {
        public 사칙연산()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            float aa = Convert.ToSingle(txtA.Text);
            float bb = Convert.ToSingle(txtB.Text);

            txtRes.Text = Convert.ToString(연산.Plus(aa, bb));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            float aa = Convert.ToSingle(txtA.Text);
            float bb = Convert.ToSingle(txtB.Text);

            txtRes.Text = Convert.ToString(연산.Minus(aa, bb));
        }

        private void btnMultply_Click(object sender, EventArgs e)
        {
            float aa = Convert.ToSingle(txtA.Text);
            float bb = Convert.ToSingle(txtB.Text);

            txtRes.Text = Convert.ToString(연산.Multiply(aa, bb));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float aa = Convert.ToSingle(txtA.Text);
            float bb = Convert.ToSingle(txtB.Text);

            txtRes.Text = Convert.ToString(연산.Divide(aa, bb));
        }
    }
}
