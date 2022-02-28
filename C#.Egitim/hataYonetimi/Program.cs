using System;

namespace hataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
         {
             Console.WriteLine("Bir sayı giriniz :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayı : " + a);
         }

         catch(Exception ex)
         {
           Console.WriteLine(ex.Message);
         }
         finally
         {
             Console.WriteLine("İşlem Tamalandı");
             Console.ReadKey();
         }                   
        }
    }
}
