using System;
using System.Collections.Generic;
using System.Globalization;
using PaymentEmployee.Entities;

namespace PaymentEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.Write("Adicional charge: ");
                    double adicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, adicionalCharge));
                }
                else if (ch == 'n')
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
