using System;

namespace ForLoopBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            Console.WriteLine("T"+" "+"Ç");
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    int c = Convert.ToInt16(i)+1;
                    if(c>sayac)
                    {
                        Console.WriteLine(i);
                    }
                    else
                        Console.WriteLine(i+" "+c);
                }
            }
            Console.WriteLine("--");
            // 1 ile girilen sayı arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek Toplam : " + tekToplam);
            Console.WriteLine("Çift Toplam : " + ciftToplam);

            Console.WriteLine("--");
            //break, continue
            for (int i = 0; i < sayac; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Dörde gelince döngü sonlandırıldı!");
                    Console.WriteLine("--");
                    break;                    
                }
                Console.WriteLine(i);
            }

           /*for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }*/
            Console.ReadKey();
        }
    }
}
