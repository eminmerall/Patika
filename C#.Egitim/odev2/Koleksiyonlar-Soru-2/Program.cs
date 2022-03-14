using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            for (int i = 0; i < 5;)
            {
                Console.Write("{0}.pozitif sayı :", i+1);

                string girilen = Console.ReadLine();
                if (!Int32.TryParse(girilen, out int sayi)) //Girileni int yapma başarısızsa veya sayı 0 dan küçükse
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz!");
                }
                else
                {
                    liste.Add(sayi);
                    i++;                   
                }
            }
            Console.Clear();
            Console.WriteLine("Dizinin Elemanları:");
            Console.WriteLine("----");
            foreach (var item in liste)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("------------");
            Console.WriteLine(" ");


            Console.WriteLine("Küçükten Büyüğe;");
            Console.WriteLine("----");
            liste.Sort();
            Console.WriteLine("Tam: ");
            
            foreach (var item in liste)
            {
                Console.Write(item+", ");
            }


            Console.WriteLine(" ");
            Console.WriteLine("------------");
            Console.WriteLine(" ");


            Console.WriteLine("Büyükten Küçüğe;");
            Console.WriteLine("----");
            liste.Reverse();
            Console.WriteLine("Tam: ");

            foreach (var item in liste)
            {
                Console.Write(item+", ");
            }


            Console.WriteLine(" ");
            Console.WriteLine("------------"); 

            Console.ReadLine();    
        }
    }
}
