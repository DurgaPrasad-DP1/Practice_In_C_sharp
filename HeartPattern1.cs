using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class HeartPattern1
    {
        public static void HP()
        {
            int i, j;
            Console.Write("Enter a number : ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = n / 2; i <= n; i += 2)
            {
                for (j = 1; j < n - i; j += 2)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
            for (i = n; i >= 1; i--)
            {
                for (j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= (i * 2) - 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}
