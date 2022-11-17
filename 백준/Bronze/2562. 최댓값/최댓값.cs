using System;
namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] str=new string[9];
            int n = 0;
            int res = 0;
            for (int i = 0; i < 9; i++)
            {
                str[i] = Console.ReadLine();
                if (int.Parse(str[i]) > res)
                {
                    res = int.Parse(str[i]);
                    n = i+1;
                }
            }

            Console.WriteLine(res+"\n"+n);

        }
    }
}
