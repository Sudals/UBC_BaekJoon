using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 2; i < N + 1; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N /= i;
                }
            }
        }
       
    }
}