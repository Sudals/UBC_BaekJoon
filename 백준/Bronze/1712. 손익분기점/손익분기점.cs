using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] str = Console.ReadLine().Split(' ');

            int[] ab = Array.ConvertAll(str, s => int.Parse(s));
 
            if(ab[1] >= ab[2])
            {
                Console.WriteLine("-1");
                return;
            }
            else
            {
                Console.WriteLine((ab[0] / (ab[2] -ab[1])) + 1);
            }
            
        }

        
    }
}