using System;

namespace class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.Isim = "Emin";
            ogrenci1.Soyisim= "Meral";
            ogrenci1.OgrenciNo= 32;
            ogrenci1.Sinif= 12;

            ogrenci1.OgrenciBilgiGetir();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgiGetir();

            Ogrenci ogrenci2 = new Ogrenci("Candan","Sumaktaş",12,1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgiGetir();





        Console.ReadLine();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        /*
            Aşağıdakiye aynı işi yapar
            public string Isim
            {
            get{ return isim; }
            set{isim = value; }
            }
        */
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }//Read onlu olması için set metodu silinebilir.
        public int Sinif { get => sinif; 
        set{
            if(value < 1)
            {
                Console.WriteLine("Sınıf birden küçük olamaz!");
                sinif=1;
            }
            else
                sinif = value; 
            } 
        }

        public Ogrenci(string ısim, string soysisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soysisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {}

        public void OgrenciBilgiGetir()
        {
            Console.WriteLine("--- Öğrenci Bilgileri ----");
            Console.WriteLine("");

            Console.WriteLine("Öğrenci Adı   :{0}",this.isim);
            Console.WriteLine("Öğrenci Soyadı   :{0}",this.soyisim);
            Console.WriteLine("Öğrenci No   :{0}",this.ogrenciNo);
            Console.WriteLine("Öğrenci Sınıf   :{0}",this.sinif);
            Console.WriteLine("");

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif+1;

        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif-1;
        }

    }
}
