using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class Patterns
    {
        public void Pat()
        {
            int i, j,n,k,l;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*", j);
                Console.Write("\n");
                for (k = 1; k <= n; k++)
                {
                    for (l = 1; l <= k; l++)
                        Console.Write("*", l);
                    Console.Write("\n");

                }
            }

        }

        public void Pat1()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} square {1}", n, n * n);
            
        }

        public static void Patt()
        {
            Patterns p = new Patterns();
            //p.Pat();
            p.Pat1();
        }
    }
}
