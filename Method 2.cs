using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Multi_thread_Visual
{
    public partial class Method_2 : Form
    {
        public Method_2()
        {
            InitializeComponent();
        }

        public void Op1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Thread.Sleep(3000);
                }
                Lst1.Invoke((MethodInvoker)delegate {
                    ListViewItem item = new ListViewItem(i.ToString());
                    Lst1.Items.Add(item);
                });
                Thread.Sleep(1000);

            }
        }
        public void Op2()
        {
            for (int i = 0; i < 10; i++)
            {
                Lst2.Invoke((MethodInvoker)delegate {
                    ListViewItem item = new ListViewItem(i.ToString());
                    Lst2.Items.Add(item);
                });

                Thread.Sleep(1000);
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread Operation1 = new Thread(Op1);
            Thread Operation2 = new Thread(Op2);
            Operation1.Start();
            Operation2.Start();
            //Operation1.Join();
            //Operation2.Join();
            //btnBacktomenu.Enabled = false;
            //if (Operation1.ThreadState == ThreadState.Stopped && Operation2.ThreadState == ThreadState.Stopped)
            //{
            //    btnBacktomenu.Enabled = true;
            //}
        }

        private void btnBacktomenu_Click(object sender, EventArgs e)
        {           
            this.Close();
            frmMain fm = new frmMain();
            fm.Show();
        }
    }
}
