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
        public class Vector2 : IComparable<Vector2>
        {
            public int x;
            public int y;
            public Vector2(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
            public int CompareTo([AllowNull] Vector2 other)
            {
                if (x > other.x)
                {
                    return 1;
                }
                else if (x == other.x)
                {
                    if (y > other.y)
                    {
                        return 1;
                    }
                    else if (y == other.y)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int tc = int.Parse(sr.ReadLine());
            List<Vector2> vec = new List<Vector2>();
            int[] input = { 0, 0 };
            for(int i = 0; i < tc; i++)
            {
                input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                vec.Add(new Vector2(input[0], input[1]));
            }
            vec.Sort();

            for(int i = 0; i < vec.Count; i++)
            {
                sw.WriteLine(vec[i].x + " " + vec[i].y);
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}