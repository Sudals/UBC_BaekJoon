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
            int colorPaper = int.Parse(Console.ReadLine());
            int[,] dp = new int[100,100]; //drawing paper
            int result = 0;
            for(int i = 0; i < colorPaper; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                for(int j = x; j < x + 10; j++)
                {
                    for(int p=y; p < y + 10; p++)
                    {
                        dp[j, p] = 1;
                    }
                }
            }
            for (int i=0; i < 100; i++){
                for(int j = 0; j < 100; j++)
                {
                    if (dp[i,j] == 1)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);

            
            
        }
    }
}
