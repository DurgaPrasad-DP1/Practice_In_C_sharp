using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class PyramidPatterns
    {
        public static void Pyramid()
        {
            int sp, len = 1;
            Console.Write("Enter Number : ");
            int n=int.Parse(Console.ReadLine());
            sp = n - 1;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=sp;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=len;k++)
                {
                    Console.Write(" * ");
                }
                sp--;
                len = len + 1;
                Console.WriteLine();
            }
        }
        public static void Pyramid1()
        {
            int sp, len = 1,t=1;
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine());
            sp = n - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sp; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= len; k++)
                {
                    Console.Write(" "+t);
                    t++;
                }
                sp--;
                len = len + 1;
                Console.WriteLine();
            }
        }
        public static void Pyramid2()
        {
            int sp, len = 1;
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine());
            sp = n - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sp; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= len; k++)
                {
                    Console.Write(k+" ");
                }
                sp--;
                len = len + 1;
                Console.WriteLine();
            }
        }
        public static void Pyramid3()
        {
            int sp, len = 1;
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine());
            sp = n - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sp; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= len; k++)
                {
                    Console.Write(i+" ");
                }
                sp--;
                len = len + 1;
                Console.WriteLine();
            }
        }
    }
}
