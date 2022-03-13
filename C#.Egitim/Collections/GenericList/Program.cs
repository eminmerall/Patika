using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>class
            //System.Collections.Generic
            //T->object

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve List.ForEach
            foreach(var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach(var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //listeden eleman çıkarma

             //ada göre çıkarma   
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            //indexe göre çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            //liste içerinde arama
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içersinde bulundu!");
            }

            //eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //diziyi listeye çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi temizleme
            hayvanListesi.Clear();

            //liste içersinde nesne tutma
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Emin";
            kullanici1.Soyisim = "Meral";
            kullanici1.Yas = 27;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Zeynep";
            kullanici2.Soyisim = "Acaruk";
            kullanici2.Yas= 25;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim="Emre",
                Soyisim="Meral",
                Yas=37 
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Ad:"+ kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyad:"+ kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaş"+ kullanici.Yas);
            }
        Console.ReadLine();
        }
    }

    public class Kullanicilar{

        private string isim;
        private string soyisim;
        private int yas;

        public string Isim{ get => isim; set=> isim = value; }
        public string Soyisim{ get => soyisim; set=> soyisim = value; }
        public int Yas{ get => yas; set => yas = value; }

    }
}
