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
            Console.WriteLine($"1-я сторона: {Side1}\n2-я сторона: {Side2}\n");
        }

        public override void EditProperty()
        {
            Console.WriteLine("Выберите свойство, значение которого нужно редактировать: \n" +
                "н - название\n" +
                "п - первую сторону\n" +
                "в - вторую сторону");

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
                    default:
                        isRightKey = false;
                        break;
                }
            } while (!isRightKey);
        }

        public static Rectangle Input()
        {
            Console.Write("\nНазвание: ");
            string name = Console.ReadLine();
            Console.Write("1-я сторона: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("2-я сторона: ");
            int side2 = int.Parse(Console.ReadLine());
            return new Rectangle(name, side1, side2);
        }
    }
}
