using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus1 = new Focus();
            Console.WriteLine(focus1.HangiMarka().ToString());
            Console.WriteLine(focus1.ArabaRengi().ToString());
            Console.WriteLine(focus1.KacTeker().ToString());

            Civic civic1 = new Civic();
            Console.WriteLine(civic1.HangiMarka().ToString());
            Console.WriteLine(civic1.ArabaRengi().ToString());
            Console.WriteLine(civic1.KacTeker().ToString());

            Corolla corolla1 = new Corolla();
            Console.WriteLine(corolla1.HangiMarka().ToString());
            Console.WriteLine(corolla1.ArabaRengi().ToString());
            Console.WriteLine(corolla1.KacTeker().ToString());

            Console.ReadLine();
            
        }
    }
}
