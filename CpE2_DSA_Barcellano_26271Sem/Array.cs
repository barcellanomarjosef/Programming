using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace CpE2_DSA_Barcellano_26271Sem
{
    public partial class frmArray : Form
    {
            string[] studentName = { "Mar", "Josef", "Velasco", "Barcellano" };
        
        public frmArray()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                lblDisplayArray.Text = studentName[Convert.ToInt32(txtIndexNumber.Text)];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtIndexNumber.Clear();
                txtIndexNumber.Focus();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int A = studentName.Length + 1;
            Array.Resize(ref studentName, A);
            studentName[A - 1] = txtValue.Text;
        }
    }
}
