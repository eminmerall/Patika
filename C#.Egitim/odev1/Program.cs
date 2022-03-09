using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Dizideki çift Sayılar
            Console.WriteLine("Dizi Uzunluğu: ");
            int dn = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[dn];

            for(int i=1;i<dn;i++)
            {
                Console.WriteLine("Dizinin "+i+". elemanı: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Çift Sayılar :");
            foreach(int i in arr)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.Write(arr[i]+" ");
                }
            }
            Console.ReadLine()
           */

           /* // n uzunluktaki dizide m ye tam bölünenler
           Console.WriteLine("Dizinin Uzunluğu: ");
           int n = Convert.ToInt32(Console.ReadLine());
           int[] ar = new int[n];

           for(int i=0; i<n; i++)
           {
               Console.WriteLine("Dizinin "+i+". elemanı");
               ar[i] = Convert.ToInt32(Console.ReadLine());
           }
           Console.WriteLine("Bölecek Sayı");
           int m = Convert.ToInt32(Console.ReadLine());

           for(int i=0; i<n; i++)
           {
               if(ar[i] % m==0)
               {
                   Console.WriteLine(ar[i]);
               }
           }
            Console.ReadLine();
            */
           /* // n uzunluktaki diziyi tersten yazdırma
           Console.WriteLine("Dizinin Uzunluğu: ");
           int n = Convert.ToInt32(Console.ReadLine());
           string[] ar = new string[n];

           for(int i=0; i<n; i++)
           {
               Console.WriteLine("Dizinin "+i+". elemanı");
               ar[i] = Console.ReadLine();
           }
           for(int i = n ; i>0 ; i--)
           {
               Console.Write(ar[i-1]+" ");
           }
           Console.ReadLine();*/

           //Girilen cümledeki kelime ve harf sayısını bulma
           Console.WriteLine("Sayılacak Cümle: ");
           string kelimeler = Console.ReadLine();
           string harfler = kelimeler;
           Console.WriteLine("----------");

           string[] kelime  = kelimeler.Split(" ");

           Console.WriteLine("Kelime Sayısı:"+kelime.Length);
           Console.WriteLine("----");
           Console.WriteLine("Harf Sayısı:"+harfler.Length);
           Console.ReadLine();
        }
    }
}
