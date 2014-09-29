using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HashtableConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("111","badol");
            aHashtable.Add("222","foyez");
            aHashtable.Add("333","moshiur");

            foreach(string newHashtable in aHashtable.Keys)
            {
                Console.WriteLine(newHashtable);
            }
            foreach (string newHashtable in aHashtable.Values)
            {
                Console.WriteLine(newHashtable);
            }
            int count = aHashtable.Count;
            Console.WriteLine(count);
            //string name = (string)aHashtable["111"];
            //Console.WriteLine(name);
            Console.ReadKey();
             
        }
    }
}
