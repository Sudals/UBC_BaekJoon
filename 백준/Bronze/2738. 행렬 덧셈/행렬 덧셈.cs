using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int[,] arr1 = new int[int.Parse(input[0]), int.Parse(input[1])];
            int[,] arr2 = new int[int.Parse(input[0]), int.Parse(input[1])];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < a; i++){
                string[] hr = Console.ReadLine().Split(' ');
                for(int j = 0; j < b; j++)
                {
                    arr1[i, j] = int.Parse(hr[j]);
                }
            }
            for (int i = 0; i <a; i++)
            {
                string[] hr = Console.ReadLine().Split(' ');
                for (int j = 0; j < b; j++)
                {
                    arr2[i, j] = int.Parse(hr[j]);
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr1[i, j] = arr2[i,j]+arr1[i,j];
                    
                    sb.Append(arr1[i,j]+" ");
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }
    }
}
