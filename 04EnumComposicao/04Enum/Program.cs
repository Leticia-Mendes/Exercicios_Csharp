using _04Enum.Entities;
using _04Enum.Entities.Enums;
using System;

namespace _04Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString(); //Converter enum para string
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");  //Converter string para enum
            Console.WriteLine(os);


        }
    }
}
