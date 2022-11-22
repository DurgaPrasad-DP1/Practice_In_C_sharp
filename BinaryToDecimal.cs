using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class BinaryToDecimal
    {
        public static void BTD()
        {
            Console.Write("Enter Binary Number : ");
            int n = int.Parse(Console.ReadLine());
            int rem, b = 1, dec = 0;
            while(n>0)
            {
                rem = n % 10;
                dec = dec + rem * b;
                n = n / 10;
                b = b * 2;
            }
            Console.WriteLine("Binary value : "+n);
            Console.WriteLine("Decimal value : "+dec);
        }
    }
}
