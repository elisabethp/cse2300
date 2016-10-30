using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BubbleSortProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean exitLoop = false;
            int n = 0;
            int num_i = 0;
            int count = 0;
            TimeSpan running_time = new TimeSpan();

            while (!exitLoop)
            {
                Console.WriteLine("Enter a number (num in array): ");
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                    exitLoop = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number.");
                }
            }

            exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Enter a number (num of iterations): ");
                try
                {
                    num_i = Int32.Parse(Console.ReadLine());
                    exitLoop = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number.");
                }
            }

            while (count <= num_i)
            {
                Stopwatch elapsedTimeBS = new Stopwatch();

                Random generator = new Random();
                int[] a = new int[n];

                for (int i = 0; i < n; i++)
                {
                    a[i] = generator.Next();
                }

                elapsedTimeBS.Start(); //starts at 0

                ///////////////////BUBBLE SORT////////////////////

                int temp;

                for (int pass = 1; pass <= a.Length - 2; pass++)
                {
                    for (int i = 0; i <= a.Length - 2; i++)
                    {
                        if (a[i] > a[i + 1])
                        {
                            temp = a[i + 1];
                            a[i + 1] = a[i];
                            a[i] = temp;
                        }
                    }
                }

                elapsedTimeBS.Stop();

                running_time = running_time + elapsedTimeBS.Elapsed;
                count++;
            }


            Console.WriteLine("\nBubble sort finished at: " + running_time.TotalMilliseconds +
                "\n Num in array: " + n + "\n Num iterations: " + num_i);
            Console.ReadLine();
        }
    }
}
