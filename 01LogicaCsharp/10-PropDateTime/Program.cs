using System;

namespace _10_PropDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2022, 2, 26, 17, 43, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);


            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine();
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            DateTime x = new DateTime(2022, 2, 26, 17, 54, 33);

            DateTime y = x.AddDays(2);
            //DateTime y = x.AddHours(2);
            //DateTime y = x.AddMilliseconds(33);
            //DateTime y = x.AddMinutes(3);
            //DateTime y = x.AddMonths(1);
            //DateTime y = x.AddSeconds(3);
            //DateTime y = x.AddTicks(900000000);
            //DateTime y = x.AddYears(1);

            TimeSpan t = x.Subtract(d);

            Console.WriteLine();
            Console.WriteLine(y);
            Console.WriteLine(t);
        }
    }
}
