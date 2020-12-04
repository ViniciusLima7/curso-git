using System;

namespace TIMESPAN
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timespan = new TimeSpan(0, 2, 30);
            Console.WriteLine(timespan);
            Console.WriteLine(timespan.Ticks);
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(3,5,30,30 );
            TimeSpan t3 = new TimeSpan(3,5,30,30 ,500);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            TimeSpan t4 = TimeSpan.FromDays(1.6);
            TimeSpan t5 = TimeSpan.FromHours(5);
            TimeSpan t6 = TimeSpan.FromMinutes(5);
            TimeSpan t7 = TimeSpan.FromSeconds(5);
            TimeSpan t8 = TimeSpan.FromMilliseconds(5);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);

            ////////////////////////////
            ///
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2021,03,27);

            TimeSpan t = d2.Subtract(d1);
            Console.WriteLine(t);
            Console.WriteLine("TIMESTAMP OK");
            Console.WriteLine("teste");
        }
    }
}
