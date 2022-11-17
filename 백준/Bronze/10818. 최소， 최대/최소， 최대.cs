using System;
namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(" ");
            string[] str = Console.ReadLine().Split(" ");
            string sb = str[0];
            string min = str[0];
            for(int i = 1; i < int.Parse(n[0]); i++)
            {
                if (int.Parse(sb) < int.Parse(str[i]))
                {
                    sb = str[i];
                }else if (int.Parse(min) > int.Parse(str[i]))
                {
                    min = str[i];
                }
                
                
            }
            Console.WriteLine(min + " "+ sb);
        }
    }
}
