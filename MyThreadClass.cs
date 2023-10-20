using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThreadingLab
{
    internal class MyThreadClass
    {
        //declaring a static method named Thread1
        public static void Thread1()
        {
            //create a loop that terminates the thread in the fifth attempt
            for (int i = 0; i <= 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);

                //using sleep() method to suspend a thread
                Thread.Sleep(1500);
            }

        }
    }
}
