using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loopDetailsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i<=999)
            //{
            //    Console.WriteLine(++i);
            //}

            int[] array = new int[400];
            int index = 0;
            for (int i = 100; i < 500; i++)
            {
                array[index] = i;
                index++;
            }

            Console.WriteLine(array[399]);
            Console.ReadKey();

        }
    }
}
