using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class ReverseString
    {
        public static void RS()
        {
           

            string str = string.Empty, Reversestr=string.Empty;
            Console.Write("Enter a string : ");
            str= Console.ReadLine();
            for(int i=str.Length-1;i>=0;i--) 
            {
                Reversestr += str[i];
            }
            Console.WriteLine("The reverse string is {0}", Reversestr);
            Console.ReadLine();
        }
        public static void CharOcc()
        {
            string str = "Website";
            Console.WriteLine("String: " + str);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int cal = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
        public static void charO()
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            while(str.Length> 0) 
            {
                Console.Write(str[0] + " = ");
                int cal = 0;  
                for(int i=0;i<str.Length;i++)
                {
                    if (str[0] == str[i])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
    }
}
