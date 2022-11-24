using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static int count=0;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int tc = int.Parse(sr.ReadLine());
            string[] input=new string[tc];
            int[] result = new int[tc];
            for(int i = 0; i < tc; i++)
            {
                count = 0;
                input[i] = sr.ReadLine();
                result[i] = isPalindrome(input[i]);
                sw.WriteLine(result[i]+" "+count);
            }
            
            sw.Flush();
            sw.Close();
            sr.Close();
        }

        static int isPalindrome(string s)
        {
            return recursion(s, 0, s.Length-1);
        }

        static int recursion(string s,int left, int right)
        {
            count++;
            if (left >= right) return 1;
            else if (!s[left].Equals(s[right]))
            {
                return 0;
            }
            else
            {
                return recursion(s, left + 1, right - 1);
            }
        }

        
        
    }
}