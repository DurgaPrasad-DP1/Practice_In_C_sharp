using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class Sumoftwomatrix
    {
        public static void SumMAtrix()
        {
            Console.Write("Enter no of Rows :");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter no of Columns :");
            int col = int.Parse(Console.ReadLine());
            int[,] a = new int[row, col];
            int[,] b = new int[row, col];
            int[,] c = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                   
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("---  First Matrix  ---");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---  Second Matrix  ---");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("---  First Matrix  +  Second Matrix ---");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(c[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
