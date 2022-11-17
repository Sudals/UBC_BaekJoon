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
            int[] d=new int[10001];
            int tmp=0;
            for(int i = 1; i < d.Length; i++)
            {
                tmp = i;
                for(int j = 0; j < i.ToString().Length; j++)
                {
                    tmp += int.Parse(i.ToString()[j].ToString());
                }
               
                if (tmp < 10001)
                {
                    d[tmp] = 1;
                }
            }
            for (int i = 1; i < d.Length; i++)
            {
                if (d[i] != 1)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}