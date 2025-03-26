using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class Triangle : Figure
    {
        int side1;
        int side2;
        int side3;

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }

        public Triangle(string name, int side1, int side2, int side3) : base(name)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Area()
        {
            double p = (side1 + side2 + side3) / 2.0;

            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"1-я сторона: {Side1}\t2-я сторона {Side2}\t3-я сторона: {Side3}");
        }
    }
}
