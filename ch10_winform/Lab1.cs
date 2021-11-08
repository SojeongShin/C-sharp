using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlTest_final
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtOutName.Text = txtName.Text;
            txtOutAge.Text = txtAge.Text;
            lbPopAge.Text = txtOutAge.Text;
            lbPopName.Text = txtOutName.Text;
        }
    }
}
