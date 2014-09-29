using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingArrayIndex
{
    class Program
    {
        static void Main(string[] args)
        {


            string Name = "Hello null World";

            int start = 0, lPosition = 0, oPosition = 0;

            Console.Write("'L' Position is : ");

            while (start < Name.Length)
            {

                lPosition = Name.IndexOf('l', start);
                if (lPosition == -1)
                    break;
                start = lPosition + 1;
                Console.Write(lPosition + " ");
            }
        }
    }
}
