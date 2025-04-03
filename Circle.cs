using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            Console.WriteLine($"Радиус: {Raduis}\n");
        }

        public override void EditProperty()
        {
            Console.WriteLine("Выберите свойство, значение которого нужно редактировать: \n" +
                "н - название\n" +
                "р - радиус");

            bool isRightKey;
            do
            {
                isRightKey = true;

                char c = Console.ReadKey(true).KeyChar;
                switch (c)
                {
                    case 'н':
                    case 'Н':
                        Console.Write("Введите новое значение для свойства \"Название\": ");
                        Name = Console.ReadLine();
                        break;
                    case 'р':
                    case 'Р':
                        Console.Write("Введите новое значение для свойства \"Радиус\": ");
                        Raduis = int.Parse(Console.ReadLine());
                        break;
                    default:
                        isRightKey = false;
                        break;
                }
            } while (!isRightKey);
        }

        public static Circle Input()
        {
            Console.Write("\nНазвание: ");
            string name = Console.ReadLine();
            Console.Write("Радиус: ");
            int radius = int.Parse(Console.ReadLine());
            return new Circle(name, radius);
        }
    }
}
