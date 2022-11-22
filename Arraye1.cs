using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class Arraye1
    {
        public static void RightRotation()
        {
            Console.Write("Enter a number right rotation : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
