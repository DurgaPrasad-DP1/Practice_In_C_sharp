using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class ReverseEachWord
    {
        public static void RES()
        {
            string s=Console.ReadLine();
            string r = string.Join(",", s.Split().Select(x=>new string(x.Reverse().ToArray())));
            Console.WriteLine(r);
        }
    }
}
