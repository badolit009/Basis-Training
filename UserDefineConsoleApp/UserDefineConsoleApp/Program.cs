using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserDefineConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Number> numbers = new List<Number>();

            
            for (int i = 0; i < 10; i++)
            {
                Number aNumber = new Number();
                aNumber.value = i;
                numbers.Add(aNumber);
            }
            foreach (Number  item in numbers)
            {
                Console.WriteLine(item.value);
            }
            Console.ReadKey();
        }
    }
}
