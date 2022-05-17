using System;
namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez(){
            Console.WriteLine("Bitkiler fotosentez yapar");
        }

        public override void UyaranlaraTepki() //Polymorphism konusu
        {
            //base.UyaranlaraTepki(); kullanılmazsa üst sınıftan geleni iptal eder.
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
    }

    public class TohumluBitkiler:Bitkiler{
        public TohumluBitkiler(){
            base.Fotosentez(); //base kalıtım aldığn üst sınıflara erişim sağlar
            base.Beslenme();
            base.Bosaltim();
            base.UyaranlaraTepki(); //Polymorphism konusu
        }
        public void TohumCogaltma(){

            Console.WriteLine("Tohumlu bitkiler tohumla coğalır");
        }
    }

    public class TohumsuzBitkiler:Bitkiler{
        public TohumsuzBitkiler(){
            base.Fotosentez(); //base kalıtım aldığn üst sınıflara erişim sağlar
            base.Beslenme();
            base.Bosaltim();
        }
        

        public void SporlaCogaltma(){

            Console.WriteLine("Tohumlusuz bitkiler sporla coğaluır");
        }

    }
}