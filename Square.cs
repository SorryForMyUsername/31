using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            Console.WriteLine($"Сторона: {Side}\n");
        }

        public override void EditProperty()
        {
            Console.WriteLine("Выберите свойство, значение которого нужно редактировать: \n" +
                "н - название\n" +
                "с - сторону");

            bool isRightKey;
            do
            {
                isRightKey = true;

                char c = Console.ReadKey(true).KeyChar;
                switch (c)
                {
                    case 'н':
                    case 'Н':
                        Console.Write("Введите новое значение для свойства \"Название\":");
                        Name = Console.ReadLine();
                        break;
                    case 'с':
                    case 'С':
                        Console.Write("Введите новое значение для свойства \"Сторона\":");
                        Side = int.Parse(Console.ReadLine());
                        break;
                    default:
                        isRightKey = false;
                        break;
                }
            } while (!isRightKey);
        }

        public static Square Input()
        {
            Console.Write("\nНазвание: ");
            string name = Console.ReadLine();
            Console.Write("Сторона: ");
            int side = int.Parse(Console.ReadLine());
            return new Square(name, side);
        }
    }
}
