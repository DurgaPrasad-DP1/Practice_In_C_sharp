using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class FibnociiSeries
    {
        public void Fib()
        {
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            c = a + b;
            Console.WriteLine(c);
            for(int i=0;i<c;i++)
            {
                if(c<=100)
                { 
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(c);
                }
            }
        }
        public void prime()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine(n+" is Prime Number ");
            }
            else
            {
                Console.WriteLine(n+" is not  a Prime Number");
            }
        }
        public static void FS()
        {
            FibnociiSeries f = new FibnociiSeries();
            //f.Fib();
            f.prime();
        }
    }
}
