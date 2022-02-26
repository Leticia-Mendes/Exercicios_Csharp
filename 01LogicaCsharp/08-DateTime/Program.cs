using System;
using System.Globalization;

namespace _08_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 02, 26);
            DateTime d2 = new DateTime(2022, 02, 26, 10, 18, 5);

            DateTime d3 = DateTime.Now;       //Data e Hora atual
            DateTime d5 = DateTime.Today;      //Data de hoje horário zerado
            DateTime d6 = DateTime.UtcNow;     //fuso horário universal

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine();
            Console.WriteLine(d3);
            Console.WriteLine(d3.Ticks);   //quantidade de ticks desde a hora zero do dia 1 ano 1
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2022-02-26");   //Dia com hora zero
            DateTime d8 = DateTime.Parse("2022-02-26 10:22:13");

            DateTime d9 = DateTime.Parse("26/02/2022");   //Dia com hora zero
            DateTime d10 = DateTime.Parse("26/02/2022 10:30:38");

            Console.WriteLine();
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

                //Com o ParseExact eu determino qual formato vou utilizar.
            DateTime d11 = DateTime.ParseExact("2022-02-26", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("26/02/2022 10:45:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(d11);
            Console.WriteLine(d12);

        }
    }
}
