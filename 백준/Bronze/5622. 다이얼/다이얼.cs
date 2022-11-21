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
            string input = Console.ReadLine();
            char[] word = input.ToCharArray();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                int a = GetDial(word[i]);
                sum += (a + 1);
            }
            Console.WriteLine(sum);
        }
        static int GetDial(char dWord)
        {
            if (dWord >= 'A' && dWord <= 'C')
                return 2;
            else if (dWord >= 'D' && dWord <= 'F')
                return 3;
            else if (dWord >= 'G' && dWord <= 'I')
                return 4;
            else if (dWord >= 'J' && dWord <= 'L')
                return 5;
            else if (dWord >= 'M' && dWord <= 'O')
                return 6;
            else if (dWord >= 'P' && dWord <= 'S')
                return 7;
            else if (dWord >= 'T' && dWord <= 'V')
                return 8;
            else if (dWord >= 'W' && dWord <= 'Z')
                return 9;
            else
                return 0;
        }
    }
}