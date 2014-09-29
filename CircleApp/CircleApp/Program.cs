using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double redius = 5;
            Circle aCircle = new Circle();
            double diameter = aCircle.GetDiameter(redius);
            double perimeter = aCircle.GetPerimeter(redius);
            double area = aCircle.GetArea(redius);

            Console.WriteLine(diameter);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
