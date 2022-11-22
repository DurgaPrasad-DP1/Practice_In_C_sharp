using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class StarPattern
    {
        public static void star()
        {
            int row, col;
            Console.Write("Enter a number : ");
            int n=int.Parse(Console.ReadLine());
            for(row=1; row<=n; row++) 
            {
                for(col=1; col<=row; col++) 
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
        public static void Pyramid()
        {
            int spc, len=1;
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            spc = n - 1;
            for (int i= 1; i <= n; i++)
            {
                for (int r = 1; r <= spc; r++)
                {
                    Console.Write(" ");
                }
                for(int s=1;s<=len;s++)
                {
                    Console.Write(" * ");
                }
                spc--;
                len = len + 1;
                Console.WriteLine();
            }
        }
        public static void NumberPattern()
        {
            int temp=1;
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(" "+temp);
                    temp++;
                }
                Console.WriteLine();
            }
        }
        public static void StringPattern()
        {
            Console.Write("Enter a string : ");
            string n = Console.ReadLine();
            for (int row = 0; row < n.Length; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(n[col]);
                }
                Console.WriteLine();
            }
        }
        public static void PyramidPattern()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int  col = 1; col <= row; col++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern()
        {
            int row, col;
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(row+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
