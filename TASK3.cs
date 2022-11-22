using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class TASK3
    {

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

        public static void DukeNumber()
        {
            Console.Write("Enter a Number :");
            int n = int.Parse(Console.ReadLine());
            int temp, a = 0;
            temp = n;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    a = 1;
                    break;
                }
                n /= 10;
            }
            if (temp > 0 && a == 1)
                Console.WriteLine(temp+"Given Number is a Duke Number");
            else
                Console.WriteLine(temp+"Given Number is not a Duke Number");
        }

        public static void Ang()
        {
            Console.Write("Enter Hours : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            int m = int.Parse(Console.ReadLine());
            double hd = (h * 30) + (m * 30.0 / 60);
            double md = m * 6;
            double diff = Math.Abs(hd - md);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"Angle between {h} hour and {m} minute is {diff} degrees");
        }

        public static void RightRotation()
        {
            Console.Write("Enter a number right rotation : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("   ---   Array elements   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int j = 0; j < n -1; j++)
            {
                temp = a[0];
                a[0] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("   ---   After Right circular rotation   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }


        public static void LeftRotation()
        {
            Console.Write("Enter a number  left rotation: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("   ---   Array elements   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int j = 0; j < n-1; j++)
            {
                temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("   ---   After Left circular rotation   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
