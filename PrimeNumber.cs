using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class PrimeNumber
    {
        public static void pm()
        {
            Console.Write("Enter a Number : ");
            int n=int.Parse(Console.ReadLine());
            int temp = 0, i;
            for(i = 1; i <= n; i++)
            {
                if(n%i==0)
                {
                temp++;
                }
            }
            if(temp==2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
        }
    }
}
