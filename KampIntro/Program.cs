using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği  (veri belirtceksek türünü yazmalıyız başına)
            //do not repeat yourself
            //değer tutucu, alias  (kategoriEtiketi)

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else if (dolarDun< dolarBugun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }




            if ( sistemeGirisYapmısMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
