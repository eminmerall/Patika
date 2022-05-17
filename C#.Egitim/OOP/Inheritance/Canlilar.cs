using System;
namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme(){
            Console.WriteLine("Canlılar Beslenir.");
        }
        protected void Bosaltim(){
            Console.WriteLine("Canlılar bosaştım yapar.");
        }

        public virtual void UyaranlaraTepki(){  //Polymorphism konusu
            Console.WriteLine("Canlılar Uyaranlara Tepki Verir");
        }
    }
}