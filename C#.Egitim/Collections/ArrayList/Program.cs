using System;
using System.Collections;
using System.Collections.Generic;
namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //listeye ekleme
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add("A");

            //verilere erişme

            //Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");
            //listeye aynı anda birden fazla ekleme ekleme

            //string[] renkler = {"Kırmızı","Sarı","Yeşil"};
            ArrayList liste2 = new ArrayList();

            List<int> sayilar = new List<int>(){1,12,6,9,5,0,15,8,4,2,5}; 
            //liste.AddRange(renkler);
            liste2.AddRange(sayilar);

            foreach (var item in liste2)
            {
                Console.WriteLine(item);
            }
            //sıralama

            Console.WriteLine("----------");
            liste2.Sort();
            foreach (var item in liste2)
            {
                Console.WriteLine(item);
            }
            //Binary Search (sıralama yapmak gerekir)
            Console.WriteLine("----------");
            Console.WriteLine(liste2.BinarySearch(15));
            Console.WriteLine("----------");

            liste2.Reverse();
            foreach (var item in liste2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
