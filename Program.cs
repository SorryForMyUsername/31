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
                    "р - редактировать значение свойства\n" +
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
                        case 'Д':
                            AddFigure(figures);
                            break;
                        case 'п':
                        case 'П':
                            OutputFigures(figures);
                            break;
                        case 'у':
                        case 'У':
                            if (figures.Count > 0) DeleteFigure(figures);
                            else isRightKey = false;
                            break;
                        case 'р':
                        case 'Р':
                            if(figures.Count > 0) SelectFigure(figures, "Выберите фигуру, у которой нужно изменить значение свойства: ").EditProperty();
                            else isRightKey = false;
                            break;
                        case 'м':
                        case 'М':
                            if (figures.Count > 0) CallFigureMethod(figures);
                            else isRightKey = false;
                            break;
                        case 'в':
                        case 'В':
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
            if (figures.Count == 0)
            {
                Console.WriteLine("Фигуры отсутствуют!");
            }
            else
            {
                foreach (Figure figure in figures)
                {
                    figure.Print();
                }
            }
        }

        static void CallFigureMethod(List<Figure> figures)
        {
            Figure figure = SelectFigure(figures, "Введите название фигуры, у которой нужно вызвать метод: ");

            Console.WriteLine("\nВыберите, какой метод вызвать:\n" +
                "а - вызвать метод, вычисляющий площадь фигуры\n" +
                "п - вызвать метод, вычисляющий периметр фигуры\n" +
                "и - вызвать метод, выводящий данные о фигуре\n");

            bool isEnd;
            do
            {
                isEnd = true;
                char c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    case 'а':
                    case 'А':
                        Console.WriteLine($"Площадь фигуры: {figure.Area():f2}");
                        break;
                    case 'п':
                    case 'П':
                        Console.WriteLine($"Периметр фигуры: {figure.Perimeter():f2}");
                        break;
                    case 'и':
                    case 'И':
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
                isEnd = false;
                char c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    case 'п':
                    case 'П':
                        figures.Add(Rectangle.Input());
                        break;
                    case 'т':
                    case 'Т':
                        figures.Add(Triangle.Input());
                        break;
                    case 'к':
                    case 'К':
                        figures.Add(Square.Input());
                        break;
                    case 'г':
                    case 'Г':
                        figures.Add(Circle.Input());
                        break;
                    default:
                        isEnd = true;
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
    }
}
