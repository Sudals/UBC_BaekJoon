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

            List<string> list = new List<string>();


            for (int i = 0; i < tc; i++)
            {
                string word = sr.ReadLine();
                list.Add(word.ToLower());
            }

            list = list.Distinct().ToList();//중복된 문자열이 들어오기때문에 중복 제거
            list.Sort();
            list = list.OrderBy(x => x.Length).ToList();//길이 순으로 정렬

            foreach (string word in list)
            {
                sw.WriteLine(word);
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}