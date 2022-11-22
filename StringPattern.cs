using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class StringPattern
    {
        public static void Pattern()
        {
            Console.Write("Enter a string : ");
            string str=Console.ReadLine();
            for (int i = 0; i <str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(str[j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
