using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad=  "Emin";
            calisan1.Soyad= "Meral";
            calisan1.No= 53;
            calisan1.Departman = "İş Analisti";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad=  "Oğuzhan";
            calisan2.Soyad= "Yalçınkaya";
            calisan2.No= 20;
            calisan2.Departman = "Ön Yüz Geliştirici";

            calisan2.CalisanBilgileri();

            Console.ReadLine();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }
    }
}
