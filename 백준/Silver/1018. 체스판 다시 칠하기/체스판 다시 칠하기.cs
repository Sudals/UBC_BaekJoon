using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static int count=0;
        static StringBuilder sb=new StringBuilder();
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '),int.Parse);
            int x = input[0];
            int y = input[1];
            List<String> board = new List<string>();
            int countW = 0;
            int countB = 0;
            string c = "W";
            List<int> result =new List<int>();
            for(int i = 0; i < x; i++)
            {
                board.Add(sr.ReadLine());
            }
            for(int i=0; i <=x - 8; i++)
            {
                for(int j=0;j <=y - 8; j++)
                {
                    countB = 0;
                    countW = 0;
                    for (int p = i; p < i + 8; p++)
                    {
                        c = (c.Equals("B")) ? "W" : "B";
                        for (int k = j; k < j + 8; k++)
                        {
                            if (board[p][k].ToString().Equals(c))
                            {
                                countB++;
                            }
                            else
                            {
                                countW++;
                            }
                            c = (c.Equals("B")) ? "W" : "B";
                        }
                    }
                    result.Add(countB);
                    result.Add(countW);

                }
            }
            Console.WriteLine(result.Min());
        }
    }
}
