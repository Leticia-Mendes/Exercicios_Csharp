using System;
using _03_Interface.Entities;
using _03_Interface.Entities.Enums;

namespace _03_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Cicle() { Radius = 2.0, Color = ColorEnum.White };
            IShape s2 = new Retangle() { Width = 3.5, Height = 4.2, Color = ColorEnum.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
