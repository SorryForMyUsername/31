using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            bool isEnd = false;
            do
            {
                Console.WriteLine("\nВыберите действие:\n" +
                    "д - добавить новый элемент\n" +
                    "п - промотреть весь список объектов\n" +
                    "у - удалить объект\n" +
                    "м - вызвать метод объекта\n" +
                    "в - выйти из программы");

                bool isRightKey;
                do
                {
                    isRightKey = true;

                    char c = Console.ReadKey(true).KeyChar;
                    switch (c)
                    {
                        case 'д':
                            AddFigure(figures);
                            break;
                        case 'п':
                            if(figures.Count > 0) OutputFigures(figures);
                            else isRightKey = false;
                            break;
                        case 'у':
                            if(figures.Count > 0) DeleteFigure(figures);
                            else isRightKey = false;
                            break;
                        case 'м':
                            if(figures.Count > 0) CallFigureMethod(figures);
                            else isRightKey = false;
                            break;
                        case 'в':
                            isEnd = true;
                            break;
                        default:
                            isRightKey = false;
                            break;
                    }
                } while (!isRightKey);
            } while (!isEnd);
        }

        static void OutputFigures(List<Figure> figures)
        {
            Console.WriteLine();
            foreach (Figure figure in figures)
            {
                figure.Print();
            }
        }

        static void CallFigureMethod(List<Figure> figures)
        {
            Figure figure = SelectFigure(figures, "Введите название фигуры, у которой нужно вызвать метод: ");

            Console.WriteLine("\nВыберите, какой метод вызвать:\n" +
                "а - вызвать метод, вычисляющий площадь фигуры\n" +
                "п - вызвать метод, вычисляющий периметр фигуры\n" +
                "и - вызвать метод, выводящий данные о фигуре");

            bool isEnd;
            do
            {
                isEnd = true;
                char c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    case 'а':
                        Console.WriteLine($"Площадь фигуры: {figure.Area()}");
                        break;
                    case 'п':
                        Console.WriteLine($"Периметр фигуры: {figure.Perimeter()}");
                        break;
                    case 'и':
                        figure.Print();
                        break;
                    default:
                        isEnd = false;
                        break;
                }
            } while (!isEnd);
        }

        static Figure SelectFigure(List<Figure> figures, string message)
        {
            bool isEnd = false;
            string figureName;
            do
            {
                Console.Write($"\n{message}");
                figureName = Console.ReadLine();

                if (figures.Exists(f => f.Name == figureName))
                {
                    isEnd = true;
                }
                else Console.WriteLine("Фигуры с таким именем не существует!");
            } while (!isEnd);

            return figures.Find(f => f.Name == figureName);
        }

        static void AddFigure(List<Figure> figures)
        {
            Console.WriteLine("\nВыберите какой тип фигуры добавить:\n"+
                "п - прямоугольник\n" +
                "т - треугольник\n" +
                "к - квадрат\n" +
                "г - круг");

            bool isEnd;
            do
            {
                isEnd = true;
                char c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    case 'п':
                        figures.Add(InputRectangle());
                        break;
                    case 'т':
                        figures.Add(InputTriangle());
                        break;
                    case 'к':
                        figures.Add(InputSquare());
                        break;
                    case 'г':
                        figures.Add(InputCircle());
                        break;
                    default:
                        isEnd = false;
                        break;
                }
            } while (isEnd);
        }

        static void DeleteFigure(List<Figure> figures)
        {
            Figure figure = SelectFigure(figures, "Введите имя объекта, который нужно удалить: ");
            figures.Remove(figure);
            Console.WriteLine($"Фигура \"{figure.Name}\"удалена!");
        }

        static Rectangle InputRectangle()
        {
            Console.Write("\nНазвание: ");
            string name = Console.ReadLine();
            Console.Write("1-я сторона: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("2-я сторона: ");
            int side2 = int.Parse(Console.ReadLine());
            return new Rectangle(name, side1, side2);
        }

        static Circle InputCircle()
        {
            Console.Write("\nНазвание: ");
            string name = Console.ReadLine();
            Console.Write("Радиус: ");
            int radius = int.Parse(Console.ReadLine());
            return new Circle(name, radius);
        }

        static Square InputSquare()
        {
            Console.Write("\nНазвание: ");
            string name = Console.ReadLine();
            Console.Write("Сторона: ");
            int side = int.Parse(Console.ReadLine());
            return new Square(name, side);
        }

        static Triangle InputTriangle()
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
