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
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Multi_thread_Visual
{
    public partial class Method_3 : Form
    {
        public Method_3()
        {
            InitializeComponent();
            
        }

        public void Op1()
        {
            long a;
            for (long i = 0; i < 3000000000; i++)
            {
                a = i;
            }
        }

        public void Op2()
        {
            long a;
            for (long i = 0; i < 3000000000; i++)
            {
                a = i;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            label.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            
           
            Thread Operation1 = new Thread(Op1);
            Thread Operation2 = new Thread(Op2);


            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            s1.Start();
            Operation1.Start();
            Operation1.Join();
            s1.Stop();
            s2.Start();
            Operation2.Start();            
            Operation2.Join();
            s2.Stop();

            double execution1 = s1.ElapsedMilliseconds;
            double execution2 = s2.ElapsedMilliseconds;

            lblThread1time.Text = $"{execution1}ms";
            lblThread2Time.Text = $"{execution2}ms";

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fm = new frmMain();
            fm.Show();
        }
    }
}
