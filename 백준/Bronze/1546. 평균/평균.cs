using System;
using System.Collections.Generic;
using System.Linq;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> stus = new List<float>();
            int n = int.Parse(Console.ReadLine());
            string[] str =Console.ReadLine().Split(" ");
            float sum = 0;
            stus = Array.ConvertAll(str, float.Parse).ToList();
            for(int i = 0; i < str.Length; i++)
            {
                sum +=stus[i]/stus.Max() * 100;
                
            }
            Console.WriteLine(sum/stus.Count);
            
        }
    }
}
