using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> myList = new List<string>();

            string[] sesli = { "a","e","i","ı","o","ö","u","ü" };

            Console.WriteLine("Bir cümle giriniz :");

            myList.Add(Console.ReadLine());

 
            for (int i = 0; i < myList.Count; i++)
                for(int j = 0; j < sesli.Length; j++)
                {
                    if (myList[i].Contains(sesli[j]))
                    {
                       list.Add(sesli[j]);
                    }
                }           
            list.ForEach(item => Console.WriteLine(item));
            Console.ReadLine();
        }
    }
}
