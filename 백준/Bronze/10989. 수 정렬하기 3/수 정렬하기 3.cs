using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int tc = int.Parse(sr.ReadLine());
            int[] countList = new int[10001];

            for(int i = 0; i < tc; i++)
            {
                countList[int.Parse(sr.ReadLine())]++;
            }
            for(int i = 0; i < 10001; i++)
            {
                if (countList[i] != 0)
                {
                    for(int j = 0; j < countList[i]; j++)
                    {
                        sw.WriteLine(i);
                    }
                }
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }

        
     
    }
}
