using System;
namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez(){
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }

    public class TohumluBitkiler:Bitkiler{
        public TohumluBitkiler(){
            base.Fotosentez(); //base kalıtım aldığn üst sınıflara erişim sağlar
            base.Beslenme();
            base.Bosaltim();
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