using System;

namespace ConsoleProg
{
    class Program
    {                                          
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba," + name+" "+surname);


        }
    }
}