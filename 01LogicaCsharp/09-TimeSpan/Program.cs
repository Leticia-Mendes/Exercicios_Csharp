using System;

namespace _09_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);     // 00:01:30

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);


            TimeSpan t2 = new TimeSpan();    //hora 00:00:00
            TimeSpan t3 = new TimeSpan(900000000L); // 00:01:30 em ticks
            TimeSpan t4 = new TimeSpan(1, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 231);

            Console.WriteLine();
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);


            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine();
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);

        }
    }
}
