using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SelectionSortProgram
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
                Stopwatch elapsedTimeSS = new Stopwatch();

                Random generator = new Random();
                int[] a = new int[n];

                for (int i = 0; i < n; i++)
                {
                    a[i] = generator.Next();
                }

                elapsedTimeSS.Start(); //starts at 0

                ///////////////////SELECTION SORT////////////////////
                int _min = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    _min = i;
                    for (int j = i; j < a.Length; j++)
                    {
                        if (a[j] < a[_min])
                            _min = j;
                    }
                    int _temp = a[i];
                    a[i] = a[_min];
                    a[_min] = _temp;
                }

                elapsedTimeSS.Stop();

                running_time = running_time + elapsedTimeSS.Elapsed;
                count++;
            }

            
            Console.WriteLine("\nSelection sort finished at: " + running_time.TotalMilliseconds +
                "\n Num in array: " + n + "\n Num iterations: " + num_i);
            Console.ReadLine();
        }
    }
}
