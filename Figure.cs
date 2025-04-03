using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal abstract class Figure
    {
        string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value)) name = "Неизвестно";
                else name = value;
            }
        }

        public Figure(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public abstract void EditProperty();
        public virtual void Print()
        {
            Console.Write($"Название фигуры: {Name}\n");
        }
    }
}
