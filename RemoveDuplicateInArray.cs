using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class RemoveDuplicateInArray
    {
        public static void RDEIA()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[50];
            int i, j, k;
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-- Array Elements --");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n;)
                {
                    if (a[j] == a[i])
                    {
                        for (k = j; k < n; k++)
                        {
                            a[k] = a[k + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            Console.WriteLine("-- After removing duplicates in an array --");
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }



        public static void RDEIA1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[50];
            int i, j;
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;
                    if (a[j] == a[i])
                        break;
                }
                if (n == j)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
