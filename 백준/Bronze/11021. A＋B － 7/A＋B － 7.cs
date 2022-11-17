using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= input; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                sb.Append("Case #" + i + ": ");
                sb.Append(a + b + "\n");
            }
            Console.Write(sb);

        }
    }
}
