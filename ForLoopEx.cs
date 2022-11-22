using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class ForLoopEx
    {
        public void forward()
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void backward()
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; n--)
            {
                Console.WriteLine(n);
            }
        }
        public void combined()
        {
            //Console.Write("Enter number : ");
            //int n = int.Parse(Console.ReadLine());
            //int n = 3;
            for (int i = 1; i <= 4; i=i+4)
            {
                for (int j = 1; j <= 4; j=j+4)
                {
                    for (int k = 1; k <= 4; k=k+4)
                    {
                        Console.WriteLine(i + " " + j +" " +k);
                    }
                }
            }
        }
        public static void forLoop()
        {
            ForLoopEx f = new ForLoopEx();
            //f.forward();
            //f.backward();
            f.combined();
        }
    }
}
