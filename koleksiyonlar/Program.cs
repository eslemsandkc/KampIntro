using System;
using System.Collections.Generic;

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Eslem", "Fatma", "Elisa", "Muharrem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //böyle ekleme yapmaya kalkarsak başta girilen değerleri kaybederiz
            //isimler[4] = "Rüveyde";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); //boş döndürür

            List<string> isimler2 = new List<string> { "Eslem", "Fatma", "Elisa", "Muharrem" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Rüveyde");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            
        }
    }
}
