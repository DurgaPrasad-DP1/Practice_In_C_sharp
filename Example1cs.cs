using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class Example1cs
    {
        public static void ex()
        {
            //for(int x=1;x<8;x++)
            //{
            //    if (x > 5)
            //        break;
            //    Console.WriteLine(x);
            //}
            int a = 5;
            int y = 3;
            a=(a>y)?y:a;
            Console.WriteLine(a);
        }
    }
}
