using System;
using System.Globalization;
using _03StringBuilder.Entities;

namespace _03StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comments c1 = new Comments("Have a nice trip!");
            Comments c2 = new Comments("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("03/22/2022 11:10", CultureInfo.InvariantCulture),
                "Traveling to New Zeland",
                "I'm going to visit this wonderfuk country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);


            Comments c3 = new Comments("Good night");
            Comments c4 = new Comments("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("03/22/2022 20:45", CultureInfo.InvariantCulture),
                "Good night guys",
                "See you tomorrow",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
