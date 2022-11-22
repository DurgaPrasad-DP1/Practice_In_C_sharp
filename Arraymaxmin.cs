using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class Arraymaxmin
    {
        public void maxmin()
        {
            int[] num=new int[10] { 1,2,3,4,5,7,6,8,9,10};
            int k = num.Max();
            Console.WriteLine(k);
        }
    }
}
