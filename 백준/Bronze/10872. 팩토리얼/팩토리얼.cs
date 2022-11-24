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

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            int tc = int.Parse(sr.ReadLine());
            int result = 1;
            for(int i = 1; i <= tc; i++)
            {
                result *= i;
            }
            sw.WriteLine(result);
            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}