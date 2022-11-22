using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class SpyNumber
    {
        public static void Spy()
        {
            int n=int.Parse(Console.ReadLine());
            int rem, sum = 0, prod = 1;
            while(n>0)
            {
                rem = n % 10;
                sum+= rem;
                prod*=rem;
                n /= 10;
            }
            if(sum==prod)
            {
                Console.WriteLine("Spy number");
            }
            else
            {
                Console.WriteLine("Not Spy number");
            }
        }
    }
}
