using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class practice1
    {
        //public void swap()
        //{
        //    int a = 200;
        //    int b = 250;
        //    a = a + b;
        //    b = a - b; 
        //    a = a - b;
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //}
        public void swap1()
        {
            int rev = 0, rem;
            Console.Write("Enter a number : ");
            int n=int.Parse(Console.ReadLine());
            int k = n;
            while(n!=0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine(rev);
            if(rev==k)
            {
                Console.WriteLine("Palindrome number");
            }
            else
            {
                Console.WriteLine("not Palindrome number");
            }
        }
    }
}
