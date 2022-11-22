using System;
using System.Text;

class UBC
{
    static void Main(string[] args)                    
    {
        StringBuilder builder = new StringBuilder();
        int N = int.Parse(Console.ReadLine());

        int[] NumArray = new int[N];
                
        for(int i=0;i<N;i++)
        {
            NumArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(NumArray);

        for(int i=0;i<N;i++)
        {
            builder.Append(NumArray[i]+"\n");
        }
        Console.WriteLine(builder);
    }
}