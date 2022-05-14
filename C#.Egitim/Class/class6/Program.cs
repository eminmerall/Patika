using System;

namespace class6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Salı);
            Console.WriteLine((int)Gunler.Perşembe); //(int) ile int değerini yazdırır
            Console.WriteLine((int)Gunler.Cumartesi); //cumaya 25 verildiği için 25 den sonraki 26 yı alır.

            int sicaklik = 32;

            if(sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Biraz daha ısınsın");

            else if(sicaklik >= (int)HavaDurumu.CokSicak)
                Console.WriteLine("Dışarısı için sıcak bir gün");
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik< (int)HavaDurumu.Sicak)
                Console.WriteLine("Hadi dışarıya çıkalımmm");

            Console.ReadLine();
        }
    }

    enum Gunler{
        Pazartesi, //Varsayılan olarak 0,1,2 olarak devam eder.
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=25,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal=20,
        Sicak=25,
        CokSicak=30
    }
}
