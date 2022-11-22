using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class SumOfDigits
    {
        public void SD()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while(n>0)
            {
                rem = n % 10;
                sum += rem;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits is : "+sum);
        }
        public void Reverse()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum*10+rem;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits is : " + sum);
        }
        public void Arm()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int rem, sum = 0,temp;
            temp = n;

            while (n > 0)
            {
                rem = n % 10;
                sum += (rem*rem*rem);
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine(temp+" is a armstrong number");
            }
            else
            {
                Console.WriteLine(temp+" is not a armstrong number");
            }
        }
        public void Palindrome()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int rem, sum = 0, temp;
            temp = n;

            while (n > 0)
            {
                rem = n % 10;
                sum = (sum*10)+ rem;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " is a Palindrome number");
            }
            else
            {
                Console.WriteLine(temp + " is not a Palindrome number");
            }
        }

        public static void Sum()
        {
            SumOfDigits s = new SumOfDigits();
            s.SD();
            s.Arm();
            s.Palindrome();
            s.Reverse();
        }
    }
}
