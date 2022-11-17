using System;
using System.IO;
using System.Text;
namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] str = Console.ReadLine().Split(" ");

            int v = int.Parse(Console.ReadLine());
            int res=0;
            for(int i = 0; i < str.Length; i++)
            {
                if (int.Parse(str[i]) == v)
                {
                    res++;
                }
            }
            Console.WriteLine(res);
        }
    }
}
