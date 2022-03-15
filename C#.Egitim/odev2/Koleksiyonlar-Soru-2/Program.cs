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

            for (int i = 0; i < 20;)
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
            foreach (var item in liste)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("----------------");
            Console.WriteLine(" ");


            Console.WriteLine("Küçükten Büyüğe;");

            liste.Sort();         
            foreach (var item in liste)
            {
                Console.Write(item+", ");
            }
            var ort = 0;

            Console.WriteLine(" ");
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write(liste[i]+", ");
                ort += Convert.ToInt32(liste[i]) ;
            }
            Console.WriteLine(" ");
            Console.WriteLine("(" + liste[0] + "+" + liste[1] + "+" + liste[2]+ ")" +"/3" + " = " + ort/3);
            Console.WriteLine(" ");
            Console.WriteLine("----------------");
            Console.WriteLine("Büyükten Küçüğe;");
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.Write(item+", ");
            }

            Console.WriteLine(" ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(liste[i]+", ");
                ort += Convert.ToInt32(liste[i]) ;
            }
            Console.WriteLine(" ");
            Console.WriteLine("(" + liste[0] + "+" + liste[1] + "+" + liste[2]+ ")" +"/3" + " = " + ort/3);

            Console.ReadLine();    
        }
    }
}
