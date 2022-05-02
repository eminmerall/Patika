using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Çalışan 1 ****");
            Calisan calisan1 = new Calisan("Emin","Meral",53,"İş Analisti");           
            calisan1.CalisanBilgileri();

            Console.WriteLine(" ");
            Console.WriteLine("***** Çalışan 2 ****");
            Calisan calisan2 = new Calisan();
            calisan2.Ad=  "Oğuzhan";
            calisan2.Soyad= "Yalçınkaya";
            calisan2.No= 20;
            calisan2.Departman = "Ön Yüz Geliştirici";

            calisan2.CalisanBilgileri();

            Console.WriteLine("***** Çalışan 3 ****");
            Calisan calisan3 = new Calisan("Ebru","Arslan");           
            calisan3.CalisanBilgileri();

            Console.ReadLine();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }
    }
}
