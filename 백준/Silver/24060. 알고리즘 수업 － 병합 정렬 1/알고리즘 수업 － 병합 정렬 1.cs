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
        static int result = 0;
        public int size;
        static bool isSet;
        static int[] sorted;
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int[] input = new int[2];
            input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] array = new int[input[0]];
            sorted = new int[input[0]];
            count = input[1];
            array = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            MergeSort(array, 0, array.Length-1);
            //for(int i = 0; i < array.Length; i++)
            //{
            //    sw.WriteLine(array[i]+" ");
            //}
            //sw.WriteLine(result);
            if (!isSet)
            {
                sw.WriteLine("-1");
            }
            sw.Flush();
            sw.Close();
            sr.Close();
        }
        static void MergeSort(int[] array,int left,int right)
        {
            if (left < right)//왼쪽이 오른쪽 보다 작을 경우만(같을 경우 하나만 남은 상태로 분할된것이므로 종료)
            {
                int middle = (left + right) / 2; //overflow 방지
                MergeSort(array, left, middle);//왼쪽 정렬
                MergeSort(array, middle+1, right);//오른쪽 정렬 같은 곳에서 시작하면 안되니까 +1
                Merge(array, middle, left, right);
            }
        }
        static void CountCheck(int n)
        {
            result++;
            if (result == count&&!isSet)
            {
                isSet = true;
                result = n;
                Console.WriteLine(result);
            }
        }
        static void Merge(int[] array, int middle, int left,int right)
        {
            int i = left;
            int j = middle+1;
            int k = left;
            int tmpr = k;
            
            while (i <= middle && j <= right)
            {
                if(array[i] <= array[j])
                {
                    sorted[k] = array[i];
                    CountCheck(array[i]);
                    i++;
                }
                else
                {
                    sorted[k] = array[j];
                    CountCheck(array[j]);
                    j++;
                }
                k++;
            }
            int tmp = k;
            //남은 데이터 삽입
            if (i > middle)
            {
                for(int t = j; t <= right; t++)
                {
                    sorted[k] = array[t];
                    CountCheck(array[t]);
                    k++;
                }
            }
            else
            {
                for(int t = i; t <= middle; t++)
                {
                    sorted[k] = array[t];
                    CountCheck(array[t]);
                    k++;
                }
            }
            for(int t=left; t <= right; t++)
            {
                array[t] = sorted[t];
            }
        }
    }
}
