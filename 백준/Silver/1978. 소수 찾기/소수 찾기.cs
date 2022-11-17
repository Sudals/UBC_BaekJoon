using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int count = 0;
            bool isPrime = true;
            for (int i = 0; i < input; i++)
            {
                isPrime = true;
                if (int.Parse(numbers[i]) != 1 && int.Parse(numbers[i]) != 0)
                {
                    for (int p = 2; p < int.Parse(numbers[i]); p++)
                    {
                        if (int.Parse(numbers[i]) % p == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            
        }
       
    }
}