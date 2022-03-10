using System;

namespace DatetimeMath_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine("----");

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine("----");


            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine("----");

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine("----");

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(20));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(15));

            Console.WriteLine("----");

            Console.WriteLine(DateTime.Now.ToString("dd")); //Ayın kaçı -10
            Console.WriteLine(DateTime.Now.ToString("ddd")); //haftanın günü(kısa) - thu
            Console.WriteLine(DateTime.Now.ToString("dddd")); // haftanın günü(uzun) - thursday

            Console.WriteLine("----");

            Console.WriteLine(DateTime.Now.ToString("MM")); //Ay 03
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Ay - mar
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Ay - March

            Console.WriteLine("----");

            Console.WriteLine(DateTime.Now.ToString("yy")); // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022

            Console.WriteLine("---------------");

            Console.WriteLine(Math.Abs(-25)); // Pozitif yapma
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(10.3)); //11 - yukarı Yuvarlar
            Console.WriteLine(Math.Round(10.6)); //11 - yukarı yuvarlar 
            Console.WriteLine(Math.Round(10.3)); //10 - aşağı yuvarlar
            Console.WriteLine(Math.Floor(10.7)); //10 - aşağı yuvarlar

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); //3^4 ü verir
            Console.WriteLine(Math.Sqrt(9)); //Karekök alır
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı
            




            Console.ReadLine();
        }
    }
}
