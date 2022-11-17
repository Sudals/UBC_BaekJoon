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

            int n = int.Parse(Console.ReadLine());
            int k = 1;
            int c = 0;
            if(n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            for(int i = 1; i <= n; i++)
            {
                k = k+6*i;
                if (n <= k)
                {
                    Console.WriteLine(i+1);
                    break;
                }
            }
        }

        
    }
}