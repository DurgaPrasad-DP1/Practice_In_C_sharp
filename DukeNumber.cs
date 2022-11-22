using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class DukeNumber
    {
        //Duck number
        public static void DN()
        {
            int n=int.Parse(Console.ReadLine());
            int temp, a = 0;
            temp = n;
            while(n>0)
            {
                if(n%10==0)
                {
                    a = 1;
                    break;
                }
                n /= 10;
            }
            if(temp>0 && a==1)
            {
                Console.WriteLine("Given Number is a Duke Number");
            }
            else
            {
                Console.WriteLine("Given Number is not a Duke Number");
            }
        }
    }
}
