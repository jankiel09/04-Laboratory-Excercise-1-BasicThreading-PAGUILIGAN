using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Lab1
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 1; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);

                // suspend the current thread for 1.5 seconds
                Thread.Sleep(1500);
            }
        }
    }//myThreadClass
}//namespacee
