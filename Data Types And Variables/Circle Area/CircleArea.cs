using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = radius * Math.PI * radius;
            Console.WriteLine("{0:f12}",area);
        }
    }
}
