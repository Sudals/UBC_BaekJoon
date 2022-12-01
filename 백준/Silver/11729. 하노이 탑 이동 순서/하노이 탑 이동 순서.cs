using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static int count=0;
        static StringBuilder sb=new StringBuilder();
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int input = int.Parse(sr.ReadLine());
            Hanoi(input, 1, 2, 3);
            Console.WriteLine(count);
            Console.WriteLine(sb);
        }

        public static void Hanoi(int N,int A,int B,int C)
        {
            count++;
            if (N == 1)
            {
                sb.AppendLine(A + " " + C);
                return;
            }
            Hanoi(N - 1, A, C, B);
            sb.AppendLine(A + " " + C);
            Hanoi(N - 1, B, A, C);
        }
    }
}
