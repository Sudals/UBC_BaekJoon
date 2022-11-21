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

                c = 0;
                int input = int.Parse(sr.ReadLine());

            bool isSet=false;
            for (int p = 0; p < input; p++)
            {
                int num = int.Parse(sr.ReadLine());
                int end = 10000;
                int[] tmp = new int[end + 1];
                if (!isSet)
                {
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
                    for (int i = 0; i < end + 1; i++)
                    {
                        if (tmp[i] != 0)
                        {
                            count.Add(tmp[i]);
                        }
                    }
                    isSet = true;
                }
                sw.WriteLine(goldbah(count, num));
            }
            sw.Flush();
            sw.Close();
            sr.Close();

        }

        public static string goldbah(List<int> count,int n)
        {
            List<int> tmpList = new List<int>();
            
            int b = 0;
            int a = 0;
            int c = 0;
            bool isFirst = false;
            for(int i = 0; i < count.Count; i++)
            {
                if (count[i] > n)
                {
                    break;
                }
                
                for(int j = i;j<count.Count;j++ )
                {
                    if (count[j] > n)
                    {
                        break;
                    }
                    if (count[i] + count[j] == n)
                    {
                        if (Math.Max(count[i], count[j]) - Math.Min(count[i], count[j]) < a-b||!isFirst)
                        {
                            isFirst = true;
                            a = Math.Max(count[i], count[j]);
                            b = Math.Min(count[i], count[j]);
                        }
                    }
                }
            }
            return b.ToString() + " " + a.ToString();
        }
    }
}
