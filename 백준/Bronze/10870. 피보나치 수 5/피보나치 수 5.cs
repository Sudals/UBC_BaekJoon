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
            int tc = int.Parse(sr.ReadLine());
            sw.WriteLine(Fibonache(tc));
            
            sw.Flush();
            sw.Close();
            sr.Close();
        }

        static long Fibonache(int value)
        {
            if(value == 0)
            {
                return 0;
            }
            if (value == 1 || value == 2)
            {
                return 1;
            }

            return Fibonache(value - 1) + Fibonache(value - 2);
        }
    }
}