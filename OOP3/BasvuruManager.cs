using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //bu şekilde yazılırsa gönderilen referanslara göre işlem yapılır
        {
            //Basvuran bilgilerini değerlendirme kodları yazılır bu bölüme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Eğer üstteki gibi yapılırsa basvurular konut kredisine baglanır sadece

            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
