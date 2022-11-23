using System;
using System.Linq;
using System.Text;

namespace UBC
{
    class Project
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int T = int.Parse(Console.ReadLine());
            int[] list = new int[T], list_count = new int[8001];

            for (int i = 0; i < T; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
                list_count[4000 + list[i]]++;
            }

            Array.Sort(list);

            sb.AppendLine(((int)Math.Round((double)list.Sum() / list.Count())).ToString());

            sb.AppendLine(list[(list.Length - 1) / 2].ToString());
            int maxval = Int32.MinValue, t = 0;
            for (int i = 0; i < list_count.Count(); i++)
            {
                if (list_count[i] == list_count.Max())
                {
                    if (t > 1) break;
                    maxval = i - 4000;
                    t++;
                }
            }
            sb.AppendLine(maxval.ToString());

            sb.AppendLine((list[list.Length - 1] - list[0]).ToString());

            Console.WriteLine(sb);
        }
    }
}