using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class Arrayex
    {
        public static void Arr1()
        {

            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        }
        public static void Arr2()
        {
            int[] arr = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }



        public static void OneToTwo()
        {
            Console.Write("no of columns :");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {

                Console.Write("Enter values [{0}] : ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int[,] ar = new int[2, 3];
            for (int k = 0; k < n; k++)
            {
                for (int l = k; l < n; l++)
                {

                    Console.Write(ar[k, l] + " " + a[i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void TDOD()
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
            Console.WriteLine();
        }




        public static void ODTT()
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
            for (int i = 0; i <x; i++)
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
                    Console.Write(b[k,l] + " ");
                }
                Console.WriteLine();
            }
        }


        public static void RightRotation()
        {
            Console.Write("Enter a number right rotation : ");
            int n=int.Parse(Console.ReadLine());
            int[] a=new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("   ---   Array elements   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            int temp;
            for(int j=0;j<n-1;j++)
            {
                temp = a[0];
                a[0] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("   ---   After Right circular rotation   ---   ");
            foreach(int i in a)
            {
                Console.Write(i+" ");
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
            for(int i=0; i <n;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
