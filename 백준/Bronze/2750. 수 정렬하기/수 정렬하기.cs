using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int i = 0; i < tc; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                list.Add(tmp);
            }
            list.Sort();
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
