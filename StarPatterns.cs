using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class StarPatterns
    {
        public static void Rectangle()
        {
            Console.Write("Enter number : ");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("");
            }
            for (int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("");
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("");
            }
        }
        public static void Triangle()
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("");
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("");
            }
        }
        public static void BackTriangle()
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("");
            }
        }
    }
}
