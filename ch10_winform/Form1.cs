using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTest_final
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtName.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            txtName.Text = "";
        }
    }
}
