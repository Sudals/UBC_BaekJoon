using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int input = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int tmp = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                tmp = int.Parse(input[0]) + int.Parse(input[1]);
                if (tmp == 0)
                {
                    break;
                }
                sb.AppendLine(tmp.ToString());
            }
            Console.WriteLine(sb);

        }
    }
}
