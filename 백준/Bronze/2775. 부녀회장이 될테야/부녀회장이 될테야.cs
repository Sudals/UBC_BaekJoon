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
            int T = int.Parse(Console.ReadLine());

            for (int l = 0; l < T; l++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[,] apart = new int[k + 1, n + 1];

                for (int i = 0; i <= n; i++)
                {
                    apart[0, i] = i;
                }

                for (int i = 1; i <= k; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        for (int o = j; o >= 1; o--)
                        {
                            apart[i, j] += apart[i - 1, o];
                        }
                    }
                }

                Console.WriteLine(apart[k, n]);
            }
        }
    }
}