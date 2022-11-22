using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class AngleHours
    {
        //Finding the angle between the hour and minute hands of a clock at any given time:
        public static void Ang()
        {
            Console.Write("Enter Hours : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            int m = int.Parse(Console.ReadLine());
            double hd = (h * 30) + (m * 30.0 / 60);
            double md = m * 6;
            double diff = Math.Abs(hd - md);
            if(diff>180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"Angle between {h} hour and {m} minute is {diff} degrees");
        }
    }
}
