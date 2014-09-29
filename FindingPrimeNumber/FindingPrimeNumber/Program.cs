using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Your Value:");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //int i;
            //for (i = 2; i <= Number; i++)
            //{
            //    if (Number % i == 0)
            //        break;

            //}
            //if (Number==i)
            //{
            //    Console.WriteLine("This Number Is Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine("This Is Not Prime");
            //}
            //Console.ReadKey();
            Console.Write("Enter Your Value:");
            int values = Convert.ToInt32(Console.ReadLine());
            int x;
            for (x = 2; x <= values; x++)
            {
                if (values % x == 0)
                    break;
            }
            if (values == x)
            {
                Console.WriteLine("This Is a Prime Number");
            }
            else {
                Console.WriteLine("This Is a Not Prime Number");
            }
            Console.ReadKey();
        }
    }
}
