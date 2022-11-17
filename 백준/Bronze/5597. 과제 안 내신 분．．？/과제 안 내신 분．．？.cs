using System;
using System.Collections.Generic;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stus = new List<int>();

            for(int i = 0; i < 28; i++)
            {
                stus.Add(int.Parse(Console.ReadLine()));
            }
            List<int> res = new List<int>();
            for(int i =1; i < 31; i++)
            {
                if (!stus.Contains(i))
                {
                    res.Add(i);
                }
            }
            Console.WriteLine(res[0] + "\n" + res[1]);
            
            
        }
    }
}
