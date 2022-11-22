using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class TASK2
    {
        public static void RES()
        {
            string s = Console.ReadLine();
            string r = string.Join(" ", s.Split().Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine(r);
        }
        public static void Reversestring()
        {
            string r = string.Empty;
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];
            for (int j = 0; j < n; j++)
            {
                a[j] = Console.ReadLine();
            }
            for (int b = 0; b < n; b++)
            {
                Console.Write(a[b] + " ");
            }
            Console.WriteLine();
            foreach (string k in a)
            {
                for (int i = k.Length - 1; i >= 0; i--)
                {
                    r += k[i];
                }
                Console.Write(r + " ");
                r = string.Empty;
            }
            Console.WriteLine();
        }




        public static void duplicate()
        {
            string s = Console.ReadLine();
            string r = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (!r.Contains(s[i]))
                {
                    r += s[i];
                }
            }
            Console.WriteLine(r);
        }

        public static void SubString()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                StringBuilder n = new StringBuilder();
                for (int j = i; j < s.Length; j++)
                {
                    n.Append(s[j]);
                    Console.Write(n + " ");
                }
            }
            Console.ReadLine();
        }

        public static void ONEDTOTWOD()
        {
            Console.Write("Enter no of Rows :");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter no of Rows :");
            int n = int.Parse(Console.ReadLine());
            int x = m * n;
            int[] a = new int[x];
            for (int i = 0; i < x; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("One dimensional array");
            for (int i = 0; i < x; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            int[,] b = new int[m, n];
            int k, l, z = 0;
            for (k = 0; k < m; k++)
            {
                for (l = 0; l < n; l++)
                {
                    z = k * m + l;
                    b[k, l] = a[z];
                    z++;

                }
            }
            Console.WriteLine("two dimensional array");
            for (k = 0; k < m; k++)
            {
                for (l = 0; l < n; l++)
                {
                    Console.Write(b[k, l] + " ");
                }
                Console.WriteLine();
            }
        }


        public static void TWODTOONED()
        {
            Console.Write("Enter no of Rows :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter no of Columns :");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            int[,] b = new int[n, m];
            for (int g = 0; g < n; g++)
            {
                for (int h = 0; h < m; h++)
                {
                    Console.Write("Enter values [{0}][{1}] : ", g, h);
                    b[g, h] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("two dimensional array :");
            for (int g = 0; g < m; g++)
            {
                for (int h = 0; h < n; h++)
                {
                    Console.Write(b[g, h] + " ");
                }
                Console.WriteLine();
            }

            int i, j, k = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    k = i * m + j;
                    a[k] = b[i, j];
                    k++;
                }
            }
            Console.WriteLine("One dimensional array :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write((a[i * m + j]) + " ");
            }

        }
    }
}
