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
            string input = Console.ReadLine();
            int N = int.Parse(input);
            int M = 0;
            int result = 0;
            for(int p = N; p != 0; p--)
            {
                M = 0;
                for (int i = 0; i < p.ToString().Length; i++)
                {

                    M += int.Parse(p.ToString()[i].ToString());

                }

                if (M + p == N)
                {
                    result = p;

                }
                
                
            }
            
            Console.WriteLine(result);
            
        }
    }
}
