using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class Circle : Figure
    {
        int raduis;

        public int Raduis
        {
            get { return raduis; }
            set
            {
                if (value < 0)
                {
                    raduis = 0;
                }
                else raduis = value;
            }
        }

        public Circle(string name, int radius) : base(name)
        {
            Raduis = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raduis, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Raduis;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {Raduis}");
        }
    }
}
