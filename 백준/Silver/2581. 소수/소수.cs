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
            int low = int.Parse(Console.ReadLine());
            int hig = int.Parse(Console.ReadLine());
            int count = 0;
            int min = 0;
            int sum = 0;
            bool isFirst = false;
            bool isPrime = true;
            for (int i = low; i <= hig; i++)
            {
                isPrime = true;
                if (i != 1 && i != 0)
                {
                    for (int p = 2; p < i; p++)
                    {
                        if (i % p == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        if (!isFirst)
                        {
                            min = i;
                            isFirst = true;
                        }
                        sum += i;
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(sum + "\n" + min);
            }
            
        }
       
    }
}