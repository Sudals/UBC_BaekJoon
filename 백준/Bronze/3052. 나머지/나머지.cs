using System;
using System.Collections.Generic;
using System.Linq;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stus = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                stus.Add(int.Parse(Console.ReadLine())%42);
            }
            stus = stus.Distinct().ToList();
            Console.WriteLine(stus.Count);
            
            
        }
    }
}
