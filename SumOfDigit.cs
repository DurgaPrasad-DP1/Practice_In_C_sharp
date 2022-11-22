using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class SumOfDigit
    {
        public static void SOD()
        {
            Console.Write("Enter a number : ");
            int n=int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while(n>0)
            {
                rem=n%10;
                sum += rem;
                n=n/10;
            }
            Console.WriteLine("Sum of Digits : "+sum);
        }
        public static void DTB()
        {
            int i;
            int[] a= new int[10];
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for(i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Decimal to Binary Value : ");
            for(i=i-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
        public static void BTD()
        {
            Console.Write("Enter a Binary Value : ");
            int n=int.Parse(Console.ReadLine());
            int dec = 0,b=1,rem;
            while(n>0) 
            {
                rem = n % 10;
                dec = dec + rem*b;
                n=n/10;
                b = b * 2;
            }
            Console.WriteLine("Binary Number: " + n);
            Console.WriteLine("Decimal: "+dec);
        }
        public static void Reversestring() 
        {
            string s = string.Empty;
            string r= string.Empty;
            Console.Write("Enter a string : ");
            s= Console.ReadLine();
            for(int i=s.Length-1;i>=0;i--) 
            {
                r += s[i];
            }
            Console.WriteLine("Resverse string is : "+r);
        }
        public static void CharOccurence()
        {
            Console.Write("Enter a string :");
            string s=Console.ReadLine();
            while(s.Length>0) 
            {
                Console.Write(s[0]+"=");
                int c = 0;
                for(int i=0;i<s.Length;i++) 
                {
                    if (s[0] == s[i])
                    {
                        c++;
                    }
                }
                Console.WriteLine(c);
                s = s.Replace(s[0].ToString(), string.Empty);
            }
        }
    }
}
