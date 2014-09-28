using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureExe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> aQueue = new Queue<int>();
            //aQueue.Enqueue(435432);
            //aQueue.Enqueue(4523);
            //aQueue.Enqueue(4354543);

            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());
            //Console.ReadKey();

            Stack<int> numbers=new Stack<int>();
            numbers.Push(23);
            numbers.Push(78);
            numbers.Push(89);
            numbers.Push(90);

            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Count);

            Console.ReadKey();
        }
    }
}
