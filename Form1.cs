using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreadingLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart threadstart = new ThreadStart(MyThreadClass.Thread1);

            //Create two threads named "ThreadA" and "ThreadB"
            Thread ThreadA = new Thread(threadstart);
            ThreadA.Name = "Thread A Process";
            Thread ThreadB = new Thread(threadstart);
            ThreadB.Name = "Thread B Process";
            Console.WriteLine(label1.Text);

            //Starting a thread
            ThreadA.Start();
            ThreadB.Start();

            //Use the join() method to stop calling the thread until the thread terminates
            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "---End of Thread---";
            Console.WriteLine(label1.Text);
        }
    }
}
