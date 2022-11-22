using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class Pattern
    {
        public static void Star()
        {
            //*
            //* *
            //* * *
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine());
            for(int row=1;row<=n;row++)
            {
                for(int col=1;col<=row;col++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
        public static void Star1()
        {
            //1
            //2 3
            //4 5 6
            int t = 1;
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(" "+t);
                    t++;
                }
                Console.WriteLine();
            }
        }
        public static void Star2()
        {
            //1
            //2 3
            //4 5 6
            int t = 1;
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col+" ");
                    t++;
                }
                Console.WriteLine();
            }
        }
        public static void Star3()
        {
            //1
            //2 3
            //4 5 6
            int t = 1;
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                    t++;
                }
                Console.WriteLine();
            }
        }
    }
}
