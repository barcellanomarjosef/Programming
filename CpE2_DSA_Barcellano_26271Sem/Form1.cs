using System;
using System.Drawing;
using System.Windows.Forms;

namespace CpE2_DSA_Barcellano_26271Sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            ArrayControl ctrl = new ArrayControl();
            ctrl.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(ctrl);
        }

        private void btnLinkedList_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            LinkedListControl ctrl = new LinkedListControl();
            ctrl.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(ctrl);
        }
        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer1.Location = new Point((ClientSize.Width - splitContainer1.Width) / 2,
                (ClientSize.Height - splitContainer1.Height) / 2);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            splitContainer1.Location = new Point((ClientSize.Width - splitContainer1.Width) / 2,
                (ClientSize.Height - splitContainer1.Height) / 2);
        }
    }
}
    
 