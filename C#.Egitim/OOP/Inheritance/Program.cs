using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                   Canlılar
            //                      Bitkiler                    Hayvanlar
            //               Tohumlu       Tohumsuz     Sürüngenler     kuşlar 

           /* 
           TohumluBitkiler th1 = new TohumluBitkiler();
            th1.Beslenme(); //canlılar sınıfından
            th1.Fotosentez(); //bitkiler sınıfından
            th1.TohumCogaltma(); //tohumlu bitkiler sınıfından

            Console.WriteLine("-----");
            Kuslar martı = new Kuslar();
            martı.Bosaltim();//canlılar sınıfından
            martı.Adaptasyon();//hayvanlar sınıfından
            martı.Ucmak(); //kuşlar sınıfından 
            */

            TohumluBitkiler th1 = new TohumluBitkiler(); //üstteki yapıda herbir nesne için kalıtım aldığı sınıflardan tek tek çağırmak gerekirken
            Console.WriteLine("-----"); // bu yapıda kalıtım aldığı sınıfları sınıf tanımında yapıldığında otomatik olarak getiriyor.
            Kuslar martı = new Kuslar();

            Console.ReadLine();
            
        }
    }
}
