using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(" ");
            int a = int.Parse(time[0]);
            int b= int.Parse(time[1]);
            int c = int.Parse(time[2]);
            if (a == b&& a==c)
            {
                Console.WriteLine(10000+a*1000);
            }else if (a == b || a == c)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else if(b == c || b==a)
            {
                Console.WriteLine(1000 + b * 100);
            }
            else
            {
                int d = Math.Max(c, Math.Max(a, b));
                Console.WriteLine(d * 100);
            }
        }
    }
}
