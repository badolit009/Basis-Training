using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodConsolApp
{
    class Program
    {

        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            double addResult;
            int subResult;
            long multiplyResult;
            double divisionResult;

            Console.Write("Enter fst number = ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter scnd number = ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("");
            //calculate(firstNumber, secondNumber);

            addResult = addition(firstNumber, secondNumber);
            subResult = subtraction(firstNumber, secondNumber);
            multiplyResult = multiplyResult(firstNumber, secondNumber);

            Console.WriteLine("Add Result : " + addResult);
            Console.WriteLine("subtraction Result : " + subResult);

        }

        private static int subtraction(int fstNumber, int scndNumber)
        {
            return fstNumber - scndNumber;
        }
        private static int subtraction(int fstNumber, int scndNumber)
        {
            return fstNumber - scndNumber;
        }

        private static int addition(int fstNumber, int scndNumber)
        {
            return fstNumber + scndNumber;
        }

        //private static void calculate(double fstNumber, double scndNumber)
        //{
        //    double result = fstNumber + scndNumber;
        //    Console.WriteLine("Addition Result is :" + result);

        //    double result1 = fstNumber - scndNumber;
        //    Console.WriteLine("Subtraction Result is :" + result1);

        //    double result2 = fstNumber * scndNumber;
        //    Console.WriteLine("Multiplicition Result is :" + result2);

        //    double result3 = fstNumber / scndNumber;
        //    Console.WriteLine("Division Result is :" + result3);

        //}
    }
}
