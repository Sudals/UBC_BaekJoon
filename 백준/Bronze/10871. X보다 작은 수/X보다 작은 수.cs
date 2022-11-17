using System;
using System.IO;
using System.Text;
namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(" ");
            string[] str = Console.ReadLine().Split(" ");
            int res=0;
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < int.Parse(n[0]); i++)
            {
                if (int.Parse(n[1]) > int.Parse(str[i]))
                {
                    sb.Append(str[i] + " ");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
