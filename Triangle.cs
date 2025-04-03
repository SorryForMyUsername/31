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
            Console.WriteLine($"1-я сторона: {Side1}\n2-я сторона {Side2}\n3-я сторона: {Side3}\n");
        }

        public override void EditProperty()
        {
            Console.WriteLine("Выберите свойство, значение которого нужно редактировать: \n" +
                "н - название\n" +
                "п - первую сторону\n" +
                "в - вторую сторону\n" +
                "т - третью сторону");

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
                    case 'п':
                    case 'П':
                        Console.Write("Введите новое значение для свойства \"Первая сторона\": ");
                        Side1 = int.Parse(Console.ReadLine());
                        break;
                    case 'в':
                    case 'В':
                        Console.Write("Введите новое значение для свойства \"Вторая сторона\": ");
                        Side2 = int.Parse(Console.ReadLine());
                        break;
                    case 'т':
                    case 'Т':
                        Console.Write("Введите новое значение для свойства \"Третья сторона\":");
                        Side3 = int.Parse(Console.ReadLine());
                        break;
                    default:
                        isRightKey = false;
                        break;
                }
            } while (!isRightKey);
        }

        public static Triangle Input()
        {
            Console.Write("\nНазвание: ");
            string name = Console.ReadLine();
            Console.Write("1-я сторона: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("2-я сторона: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("3-я сторона: ");
            int side3 = int.Parse(Console.ReadLine());
            return new Triangle(name, side1, side2, side3);
        }
    }
}
