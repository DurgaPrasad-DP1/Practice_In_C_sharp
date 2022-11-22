using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class fact
    {
        public void facto()
        {
            Console.WriteLine("Using For Loop");
            Console.Write("Enter number : ");
            int n=int.Parse(Console.ReadLine());
            int i, k = 1;
            for(i=1;i<=n;i++)
            {
                k = k * i;
                Console.WriteLine("Factorial of "+i+" value is "+k);
            }
            //Console.WriteLine("factorial of "+n+" value is "+k);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
        }

        public void facto1()
        {
            Console.WriteLine("Using while Loop");
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            int i=1, k = 1;
           while(i<=n)
            {
                k = k * i;
                Console.WriteLine("Factorial of " + i + " value is " + k);
                i++;
            }
           
        }
        public static void Factor()
        {
            fact f=new fact();
            f.facto();
            f.facto1();
        }
    }
}
