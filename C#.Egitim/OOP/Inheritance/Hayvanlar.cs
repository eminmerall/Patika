using System;
namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }

        public override void UyaranlaraTepki() //Polymorphism konusu
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }


    public class Surungenler:Hayvanlar{
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
        }
        public void Surunmek(){
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuslar:Hayvanlar{
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.UyaranlaraTepki();//Polymorpsihsm
        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçarak hareket ederler.");
        }
    }
}