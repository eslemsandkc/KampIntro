using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";

            // üstteki gibi manuel yazarsak işten atılırız boşa zaman kaybı ... statik

            //array - dizi .... dinamik kodlamak için kurslar.length ekledik 

            //for genel amaçlı dolaşma .. foreach dizileri kolay dolaşma amaçlı

            string[] kurslar = new string[] {"Yazılım Geliştirici Kampı","Programlamaya başlangıç","Java","Phyton","C#"};

            for (int i = 0; i< kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
