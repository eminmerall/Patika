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
        }
    }
}
