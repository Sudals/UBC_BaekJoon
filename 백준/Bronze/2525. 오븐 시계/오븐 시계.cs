using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(" ");
            int u = int.Parse(Console.ReadLine());
            int h= int.Parse(time[0]);
            int m = int.Parse(time[1]);
            int luv = (m + u) / 60;
            if ((m + u) < 60)
            {
                Console.WriteLine(h + " " + (m + u));
            }
            else if(luv+h < 24)
            {
                Console.WriteLine(luv+h+" " + (m + u) % 60);
            }
            else
            {
                Console.WriteLine(luv + h - 24 + " " + (m + u) % 60);
            }
        }
    }
}
