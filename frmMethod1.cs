using System;
using System.Threading;
using System.Windows.Forms;

namespace Multi_thread_Visual
{
    public partial class frmMethod1 : Form
    {
        public frmMethod1()
        {
            InitializeComponent();
        }
        public void Op1()
        {
            for (int i = 4; i >= 0; i--)
            {
                lstThread1.Invoke((MethodInvoker)delegate
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    lstThread1.Items.Add(item);
                });
                Thread.Sleep(1000);
            }
        }
        public void Op2()
        {
            for (int i = 0; i < 5; i++)
            {
                LstThread2.Invoke((MethodInvoker)delegate
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    LstThread2.Items.Add(item);
                });

                Thread.Sleep(1000);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lstThread1.Visible = true;
            LstThread2.Visible = true; 
            Thread Operation1 = new Thread(new ThreadStart(Op1));
            Thread Operation2 = new Thread(new ThreadStart(Op2));
            Operation1.Start();
            Operation2.Start();
        }

        private void btnBacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fm = new frmMain();
            fm.Show();
        }

    }
}
