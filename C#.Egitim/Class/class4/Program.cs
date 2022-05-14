using System;

namespace class4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi); //Public olana erişilebilir

            //Çalışan sınıfından nesne yaratma
            Calisan calisan1 = new Calisan("Emin","Meral","Analist");//public olan çalışır
            Calisan calisan2 = new Calisan("Ebru","Arslan","Analist");
            Calisan calisan3 = new Calisan("Candan","Sumaktaş","Yazılımcı");
            Calisan calisan4 = new Calisan("Oğuzhan","Yalçınkaya","Yazılımcı");
            Calisan calisan5 = new Calisan("Furkan Batuhan","Ayçiçek","Siber Güvenlik");

            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi); //Public olana erişilebilir

            
            Console.WriteLine("Toplama İşleminin sonucu: {0}",Islemler.Topla(100,200)); //Statik sınıfların nesnelerine böyle ulaşılır.
            Console.WriteLine("Çıkarma İşleminin sonucu: {0}",Islemler.Cikar(400,200));




            Console.ReadLine();
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi= 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;

        }

    }
    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar (int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
