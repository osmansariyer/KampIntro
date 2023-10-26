using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool  sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else 
            { 
                Console.WriteLine("Değişmediş Butonu");
            }

            if (sistemeGirisYapmisMi==true) 
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(ogrenciSayisi);
            //Console.WriteLine(faizOrani);
            //Console.WriteLine(sistemeGirisYapmisMi);



        }
    }
}
