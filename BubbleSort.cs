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
            int MAX_ELEMENTS = 0;

            while (!exitLoop)
            {
                Console.WriteLine("Enter a number: ");
                try
                {
                    MAX_ELEMENTS = Int32.Parse(Console.ReadLine());
                    exitLoop = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number.");
                }
            }

            Random generator = new Random();
            int[] a = new int[MAX_ELEMENTS];

            for (int i = 0; i < MAX_ELEMENTS; i++)
            {
                a[i] = generator.Next();
            }

            Console.WriteLine("The numbers in the array are: ");
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }

            ///////////////////BUBBLE SORT////////////////////

            int temp;

            Stopwatch elapsedTimeBS = new Stopwatch();
            elapsedTimeBS.Start();

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
            Console.WriteLine("Bubble sort finished at: " + elapsedTimeBS.Elapsed);

            Console.Write("The Sorted array: ");
            foreach (int aa in a)
                Console.Write(aa + " ");

            Console.ReadLine();
        }
    }
}
