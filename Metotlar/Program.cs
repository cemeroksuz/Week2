using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun[] meyveler = new Urun[] { };

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı: " + urun.Adi);
                Console.WriteLine("Ürün Fiyatı: " + urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması: " + urun.Aciklama);
                Console.WriteLine("--------------");
                
            }

            //instnce - örnek
            //encapsulation 
            Console.WriteLine("--------------Metotlar--------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}


