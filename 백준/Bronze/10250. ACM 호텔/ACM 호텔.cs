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
            
            int input = int.Parse(Console.ReadLine());
            string[] result = new string[input];
            for (int i = 0; i < input; i++)
            {
                string[] Guest = Console.ReadLine().Split();
                int h = int.Parse(Guest[0]);
                int w = int.Parse(Guest[1]);
                int n = int.Parse(Guest[2]);
                int x = 1;
                int y = 1;
                while (true)
                {
                    if (n > h)
                    {
                        n =n- h;
                        y++;
                    }
                    else
                    {
                        x = n;
                        break;
                    }
                }
                if (y < 10)
                {
                    result[i]=(x+"0"+y);
                }
                else {
                    result[i] = (x.ToString()+y.ToString());
                }
            }
            for(int i = 0; i < input; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}