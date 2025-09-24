using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace _04Lab1
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                string output = $"Name of Thread: {thread.Name} Process = {loopCount}";

                Console.WriteLine(output);
                Debug.WriteLine(output);
                System.Diagnostics.Trace.WriteLine(output);

                // suspend the current thread for 1.5 seconds 
                Thread.Sleep(1500);
            }

        }
    }//myThreadClass
}//namespacee
