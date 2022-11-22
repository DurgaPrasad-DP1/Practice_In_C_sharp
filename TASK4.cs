using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_In_C_sharp
{
    internal class TASK4
    {
        public static void AreaofRectange()
        {
            Console.Write("Enter Length : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Enter Width : ");
            int w = int.Parse(Console.ReadLine());
            int a = l * w;
            Console.WriteLine("Area of Rectangle : "+a);
        }
        public static void AreaofSquare()
        {
            Console.Write("Enter square : ");
            int s = int.Parse(Console.ReadLine());
            int a = s * s;
            Console.WriteLine("Area of square : " + a);
        }
        public static void AreaofTriangle()
        {
            Console.Write("Enter Height: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Base : ");
            int b = int.Parse(Console.ReadLine());
            int a = (1/2)*b * h;
            Console.WriteLine("Area of Traingle : " + a);
        }
        public static void AreaofCircle()
        {
            Console.Write("Enter radius: ");
            int r = int.Parse(Console.ReadLine());
            double a = 3.141 * (r * r);
            Console.WriteLine("Area of Circle : " + a);
        }
        public static void SurfaceAreaofCube()
        {
            Console.Write("Enter side Length of the Cube: ");
            int a = int.Parse(Console.ReadLine());
            double area = 6 * (a * a);
            Console.WriteLine("Surface area of cube : " + area);
        }
    }
}
