using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class Rectangle : Figure
    {
        int side1;
        int side2;

        public int Side1
        {
            get { return side1; }
            set
            {
                if (value < 0)
                {
                    side1 = 0;
                }
                else side1 = value;
            }
        }
        public int Side2
        {
            get { return side2; }
            set
            {
                if (value < 0)
                {
                    side2 = 0;
                }
                else side2 = value;
            }
        }

        public Rectangle(string name, int side1, int side2) : base(name)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return (side1 + side2) * 2;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"1-я сторона: {Side1}\t2-я сторона: {Side2}");
        }
    }
}
