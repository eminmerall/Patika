using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList aListe = new ArrayList();
            ArrayList bListe = new ArrayList();


            for (int i = 0; i < 20;)
            {
                Console.Write("{0}.pozitif sayı :", i+1);

                string girilen = Console.ReadLine();
                if (!Int32.TryParse(girilen, out int sayi) || sayi<0) //Girileni int yapma başarısızsa veya sayı 0 dan küçükse
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz!");
                }
                else
                {
                    i++;
                    int sayac = 0;

            	    for (int j = 2; j < sayi; j++)
            	    {
                        if (sayi % j == 0)
                        {
                                sayac++;
                        }
            	    }
                    if(sayac == 0)
                    {
                        aListe.Add(sayi);
                    }
            	    else
            	    {
                	    bListe.Add(sayi);
            	    }
                }        
            }
            Console.Clear();

            int sayiA = 0;
            var ortA = 0;
            int sayiB = 0;
            var ortB = 0;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*****   Asal Liste   *****");
            Console.WriteLine("");
            Console.WriteLine("Sırasız:");
            foreach (var item in aListe)
            {
                Console.Write(item+", ");                          
            }

            Console.WriteLine("");
            Console.WriteLine("----");

            aListe.Sort();
            Console.WriteLine("Sıralı:");
            foreach (var item in aListe)
            {
                Console.Write(item+", ");
                sayiA = sayiA + Convert.ToInt32(item); 
            }

            Console.WriteLine("");
            ortA = sayiA / aListe.Count;
            Console.WriteLine("----");
            Console.WriteLine("Eleman Sayısı: " + aListe.Count);
            Console.WriteLine("Ortalama: "+ ortA);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("*** Asal Olmayan Liste ***");
            Console.WriteLine("");
            Console.WriteLine("Sırasız:");
            foreach (var item in bListe)
            {
                Console.Write(item+", ");
            }

            Console.WriteLine("");
            Console.WriteLine("----");

            bListe.Sort();
            Console.WriteLine("Sıralı:");
            foreach (var item in bListe)
            {
                Console.Write(item+", ");
                sayiB = sayiB + Convert.ToInt32(item); 
            }

            ortB = sayiB / bListe.Count;
            Console.WriteLine("");
            Console.WriteLine("----");
            Console.WriteLine("Eleman Sayısı: " + bListe.Count);
            Console.WriteLine("Ortalama: " + ortB);

            Console.ReadLine();
            
        }

    }
}
