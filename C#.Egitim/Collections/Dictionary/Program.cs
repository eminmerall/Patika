using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            //eleman ekleme
            kullanicilar.Add(7,"Emin MERAL");
            kullanicilar.Add(5,"Emre MERAL");
            kullanicilar.Add(1,"Mükerrem MERAL");

            //elemena erişme       
            Console.WriteLine("*** Elemanlara erişme ***");    
            Console.WriteLine(kullanicilar[5]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
            //count
            Console.WriteLine("*** Sayma ***");
            Console.WriteLine(kullanicilar.Count);          

            //contains
            Console.WriteLine("*** İçeriyor mu? ***");
            Console.WriteLine(kullanicilar.ContainsKey(4));
            Console.WriteLine(kullanicilar.ContainsValue("Emin MERAL"));

            //silme
            Console.WriteLine("*** Silme ***");
            kullanicilar.Remove(7);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*** Keys ***");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*** Values ***");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
