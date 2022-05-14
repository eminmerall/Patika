using System;

namespace class5
{
    class Program
    {
        static void Main(string[] args)
        {
            Diktortgen diktortgen = new Diktortgen();
            diktortgen.KisaKenar = 10;
            diktortgen.UzunKenar= 22;
            Console.WriteLine("Class alan hesabı :{0}",diktortgen.AlanHesapla());

            Diktortgen_struct diktortgen_struct; // = new Diktortgen_struct();
            diktortgen_struct.KisaKenar = 5;
            diktortgen_struct.UzunKenar= 18;
            Console.WriteLine("Struct alan hesabı :{0}",diktortgen_struct.AlanHesapla());

            Console.ReadLine();
        }
    }

    class Diktortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Diktortgen_struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
