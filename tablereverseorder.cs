using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class tablereverseorder
    {
        public void table()
        {
            int i, k = 1;
            Console.WriteLine("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            for(i=10;i>=k;i--)
            {
                int l = i * n;
                Console.WriteLine(i+"*"+n+"="+l);
            }
        }
        public static void Tab()
        {
            tablereverseorder t = new tablereverseorder();
            t.table();
        }
    }
}
