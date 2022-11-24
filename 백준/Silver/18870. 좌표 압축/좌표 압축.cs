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
            List<int> lists = new List<int>();
            List<int> result = new List<int>();
            string[] input = sr.ReadLine().Split(' ');
            for(int i =0; i < tc; i++)
            {
                lists.Add(int.Parse(input[i]));
            }

            result = lists.Distinct().ToList();
            result.Sort();
            for (int i = 0; i < lists.Count; i++)
            {
                sb.Append(lower_bound(lists[i],result,result.Count-1)+" ");

            }
            Console.WriteLine(sb);
            sw.Flush();
            sw.Close();
            sr.Close();
        }
        public static int lower_bound(int target, List<int> vdata, int length)
        {
            int left = 0;
            int right = length;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (vdata[mid] >= target)
                    right = mid;
                else
                    left = mid + 1;
            }
            return right;
        }
    }
}