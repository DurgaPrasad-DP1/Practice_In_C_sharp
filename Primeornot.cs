using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class Primeornot
    {
        public static void Prime()
        {
            int a = 0;
            Console.Write("Enter a number : ");
            int n=int.Parse(Console.ReadLine());    
            for(int i = 1; i<=n;i++)
            {
                if(n%i==0)
                {
                    a++;
                }
            }
            if(a==2)

            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("not Prime Number");
            }
        }
    }
}
