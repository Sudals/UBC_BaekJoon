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
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            List<int> count = new List<int>();
            int c = 0;
            while (true)
            {
                c = 0;
                string input = sr.ReadLine();
                if (input.Equals("0"))
                {
                    break;
                }
                int start = int.Parse(input)+1;
                int end = int.Parse(input)*2;
                int[] tmp = new int[end + 1];
                
                for (int i = 2; i < tmp.Length; i++)
                {
                    tmp[i] = i;
                }
                if (end == 4)
                {
                    tmp[end] = 0;
                }
                for (int i = 2; i < Math.Sqrt(end); i++)
                {
                    if (tmp[i] != 0)
                    {
                        for (int j = i * 2; j <= end; j += i)
                        {

                            tmp[j] = 0;
                        }
                    }
                }
                for (int i = start; i < end + 1; i++)
                {
                    if (tmp[i] != 0)
                    {
                        c++;
                    }
                }
                sw.WriteLine(c);
            }
            sw.Flush();
            sw.Close();
            sr.Close();

        }
    }
}
