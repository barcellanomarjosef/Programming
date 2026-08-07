using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpE2_DSA_Barcellano_26271Sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtFname.Text + " " + txtMI.Text + ". " + txtLname.Text + "Github");
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
           frmArray frmArray = new frmArray();
            frmArray.Show();
            this.Hide();
        }
    }
}
