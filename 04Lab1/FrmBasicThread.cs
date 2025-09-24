using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace _04Lab1
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA;
        private Thread ThreadB;

        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // greyed out the run button to isolate the process. prevent multiple clicks.
            btnStart.Enabled = false;
            lblStatus.Text = "Threads are running...";

            Debug.WriteLine("-Before starting thread-");
            System.Diagnostics.Trace.WriteLine("-Before starting thread-");

            ThreadStart threadStart1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart threadStart2 = new ThreadStart(MyThreadClass.Thread1);

            // create two threads named ThreadA and ThreadB
            ThreadA = new Thread(threadStart1);
            ThreadB = new Thread(threadStart2);

            // set thread names
            ThreadA.Name = "ThreadA";
            ThreadB.Name = "ThreadB";

            Console.WriteLine("Starting ThreadA and ThreadB...");
            Console.WriteLine("================================");

            // start both threads
            ThreadA.Start();
            ThreadB.Start();

            // Join() method to wait for both threads to complete
            ThreadA.Join();
            ThreadB.Join();


            string endMessage = "-End of Thread-";
            Debug.WriteLine(endMessage);
            System.Diagnostics.Trace.WriteLine(endMessage);
            Console.WriteLine(endMessage);

            Console.WriteLine("================================");
            Console.WriteLine("Both threads have completed.");

            // update the label to show threads have ended
            lblStatus.Text = "-End Of Thread-";
            btnStart.Enabled = true; // un-grey the run button.
        }
    }
}
