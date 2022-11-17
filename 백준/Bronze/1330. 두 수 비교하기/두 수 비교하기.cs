using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(" ");
            if (int.Parse(s[0]) > int.Parse(s[1])) { Console.WriteLine(">"); }
            else if (int.Parse(s[0]) == int.Parse(s[1])) { Console.WriteLine("=="); }
            else { Console.WriteLine("<"); }
        }
    }
}
