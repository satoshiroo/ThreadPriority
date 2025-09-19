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

namespace ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        Thread ThreadA, ThreadB, ThreadC, ThreadD;

        public enum ThreadPriority
        {
            BelowNormal = 0,
            Normal = 1,
            AboveNormal = 2,
            Highest = 3
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadC = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread2);
            Thread ThreadD = new Thread(MyThreadClass.Thread2);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";
            ThreadC.Name = "Thread C";
            ThreadD.Name = "Thread D";

            ThreadA.Priority = System.Threading.ThreadPriority.Highest;
            ThreadB.Priority = System.Threading.ThreadPriority.Normal;
            ThreadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            ThreadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End of Thread-";

        }

        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void frmTrackThread_Load(object sender, EventArgs e)
        {

        }
    }
}
