using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = 1;
            if (input.Length == 1)
            {
                input = "0" + input;
            }
            string A = input.Substring(0, 1);
            string B = input.Substring(1, 1);
            
            int tmp = int.Parse(A) + int.Parse(B);
            string C = B.ToString() + (tmp%10).ToString();


            while (int.Parse(C)!=0)
            {
                n++;
                if (C.Length == 1)
                {
                    C = "0" + C;
                }
                A = C.Substring(0, 1);
                B = C.Substring(1, 1);
                tmp = (int.Parse(A) + int.Parse(B));
                C = B.ToString() + (tmp%10).ToString();
                if (C.Equals(input))
                {
                    break;
                }
               
            }
            Console.WriteLine(n);

        }
    }
}
