using System;
using System.Collections.Generic;
using System.Linq;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stus = new List<string>();
            List<int> res = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int[] score = new int[n];
            int tmp = 0;
            for (int i = 0; i < n; i++)
            {
                tmp = 0;
                stus.Add(Console.ReadLine());
                for(int j = 0; j < stus[i].Length; j++)
                {
                    if (stus[i][j].Equals('O'))
                    {
                        ++tmp;
                        score[i] += tmp;
                        
                    }else if (stus[i][j].Equals('X'))
                    {
                        tmp = 0;
                    }
                }
            }
            for(int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(score[i]);
            }

            
        }
    }
}
