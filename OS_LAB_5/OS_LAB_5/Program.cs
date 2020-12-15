using System;
using System.Diagnostics;

namespace OS_LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            int[] a = new int[2];
            

            for (int j = 0; j < 10000000; j++)
            {
                a[0]+=2;
            }

           // a[1] = a[0];

            Console.WriteLine(a[0]);

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

        }
    }
} 
