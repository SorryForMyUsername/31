using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class Square : Figure
    {
        int side;

        public int Side
        {
            get { return side; }
            set
            {
                if(value < 0)
                {
                    side = 0;
                }
                else side = value;
            }
        }

        public Square(string name, int side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

        public override double Perimeter()
        {
            return Side * 4;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона: ");
        }
    }
}
