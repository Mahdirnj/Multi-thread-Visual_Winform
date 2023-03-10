using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_thread_Visual
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMethod1_Click(object sender, EventArgs e)
        {
            frmMethod1 f1 = new frmMethod1();
            this.Hide();
            f1.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Method_2 f2 = new Method_2();
            this.Hide();
            f2.Show();
        }

        private void btnMethod3_Click(object sender, EventArgs e)
        {
            Method_3 f3 = new Method_3();
            this.Hide();
            f3.Show();
        }
    }
}
