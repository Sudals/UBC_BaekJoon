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

            Console.WriteLine(HanSu(int.Parse(Console.ReadLine())));
        }

        public static int HanSu(int n)
        {
            int tmp = 0;
            int res = 0;
            for(int i = 1; i <= n; i++)
            {
                if (i <= 99)
                {
                    res++;
                }
                else
                {
                    if (i.ToString()[0] - i.ToString()[1] == i.ToString()[1] - i.ToString()[2])
                    {
                        
                        res++;
                    }
                    
                }
            }
            return res;
        }
    }
}