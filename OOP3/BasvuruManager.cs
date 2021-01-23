using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            //başvuru işlemleri yapılır  
            //KonutKrediManaer konutKrediManaer = new KonutKrediManaer();
            //konutKrediManaer.Hesapla();
            //yukarıdaki tanım çalışır ancak konut kredisini hesaplayacağı için kullanımı yanlıştır

            //aşaıdaki gibi parametre göndererek çalışırsak hangi türde kredi gönderirsek o türde çalışır.
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
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
