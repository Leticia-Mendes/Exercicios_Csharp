using System;

namespace Exception01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Number A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Number B: ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine(a + " / " + b + " = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error! Divide by zero is not allowed! ");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
