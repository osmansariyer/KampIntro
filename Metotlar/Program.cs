using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            //Urun urun3 = new Urun();
            //urun3.Adi = "Elma";
            //urun3.Fiyati = 15;
            //urun3.Aciklama = "Amasya Elması";

            Urun[] urunler = new Urun[] {urun1, urun2};

            //type-safe 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("------------Metotlar------------");

            //instance - Örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,26);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 24,40);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 36,46);
        }
    }
}
