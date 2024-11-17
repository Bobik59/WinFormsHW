namespace SPHWModulThreeCastOne
{
    public partial class Form1 : Form
    {

        private Thread primeThread;
        private Thread fibonacciThread;

        private volatile bool stopPrime = false;
        private volatile bool stopFibonacci = false;

        private ManualResetEvent primePause = new ManualResetEvent(true);
        private ManualResetEvent fibonacciPause = new ManualResetEvent(true);
        public Form1()
        {
            InitializeComponent();
        }


        private void btnStartPrimes_Click(object sender, EventArgs e)
        {
            stopPrime = false;

            int lowerBound = 2;

            int upperBound = int.MaxValue;

            if (int.TryParse(txtLowerBound.Text, out int lower))
                lowerBound = lower;

            if (int.TryParse(txtUpperBound.Text, out int upper))
                upperBound = upper;

            primeThread = new Thread(() => GeneratePrimes(lowerBound, upperBound));
            primeThread.IsBackground = true;
            primeThread.Start();
        }

        private void btnStartFibonacci_Click(object sender, EventArgs e)
        {
            stopFibonacci = false;
            fibonacciThread = new Thread(GenerateFibonacci);
            fibonacciThread.IsBackground = true;
            fibonacciThread.Start();
        }

        private void btnStopPrimes_Click(object sender, EventArgs e)
        {
            stopPrime = true;
        }

        private void btnStopFibonacci_Click(object sender, EventArgs e)
        {
            stopFibonacci = true;
        }

        private void btnPausePrimes_Click(object sender, EventArgs e)
        {
            primePause.Reset();
        }

        private void btnResumePrimes_Click(object sender, EventArgs e)
        {
            primePause.Set();
        }

        private void btnPauseFibonacci_Click(object sender, EventArgs e)
        {
            fibonacciPause.Reset();
        }

        private void btnResumeFibonacci_Click(object sender, EventArgs e)
        {
            fibonacciPause.Set();
        }

        private void GeneratePrimes(int lower, int upper)
        {
            for (int num = lower; num <= upper; num++)
            {
                primePause.WaitOne();
                if (stopPrime) break;

                if (IsPrime(num))
                {
                    Invoke((MethodInvoker)(() => listBoxPrimes.Items.Add(num)));
                    Thread.Sleep(100);
                }
            }
        }

        private void GenerateFibonacci()
        {
            long a = 0, b = 1;

            Invoke((MethodInvoker)(() => listBoxFibonacci.Items.Add(a)));
            Invoke((MethodInvoker)(() => listBoxFibonacci.Items.Add(b)));

            while (!stopFibonacci)
            {
                fibonacciPause.WaitOne();
                long next = a + b;

                Invoke((MethodInvoker)(() => listBoxFibonacci.Items.Add(next)));
                a = b;
                b = next;

                Thread.Sleep(200);
            }
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxFibonacci.Items.Clear();
            listBoxPrimes.Items.Clear();   
        }
    }
}