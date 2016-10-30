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

            ///////////////////SELECTION SORT////////////////////

            Stopwatch elapsedTimeSS = new Stopwatch();
            elapsedTimeSS.Start();

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
            Console.WriteLine("\nSelection sort finished at: " + elapsedTimeSS.Elapsed);

            Console.Write("The Sorted array: ");
            foreach (int aa in a)
                Console.Write(aa + " ");

            Console.ReadLine();
        }
    }
}
