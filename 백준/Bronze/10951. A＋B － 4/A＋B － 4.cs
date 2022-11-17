using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                string[] AB = input.Split();
                int a = int.Parse(AB[0]);
                int b = int.Parse(AB[1]);
                Console.WriteLine(a + b);
            }

        }
    }
}
