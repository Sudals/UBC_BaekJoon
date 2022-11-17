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

            int n = int.Parse(Console.ReadLine());
            int m=0;
            int j = 0;
            int k = 0;
            while(true){
                m++;
                j += m;
                if (n <= j)
                {
                    break;
                }
            }

            for(int i = j - m+1; i <= n; i++)
            {
                k++;
            }
            if (m % 2 == 0)
            {
                Console.WriteLine(k + "/" + (m-k+1));
            }
            else
            {
                Console.WriteLine((m-k+1) + "/" + k);
            }
        }

        
    }
}