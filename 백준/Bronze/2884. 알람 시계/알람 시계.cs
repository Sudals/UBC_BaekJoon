using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dateTime = Console.ReadLine().Split(" ");
            
            if (int.Parse(dateTime[1]) - 45 >= 0)
            {
                Console.WriteLine(dateTime[0] + " " + (int.Parse(dateTime[1]) - 45));
            }
            else
            {
                if (int.Parse(dateTime[0]) != 0)
                {
                    Console.WriteLine((int.Parse(dateTime[0])-1) + " " + (60-(45-int.Parse(dateTime[1]))));
                }
                else
                {
                    Console.WriteLine("23 " + (60 - (45 - int.Parse(dateTime[1]))));
                }
            }
        }
    }
}
