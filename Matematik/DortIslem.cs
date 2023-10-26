using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {
        public  void Topla(int sayi1, int sayi2)
        {
            int toplam=sayi1+sayi2;

            Console.WriteLine(toplam);

        }

        public void Cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;

            Console.WriteLine(sonuc);

        }

        public void Carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;

            Console.WriteLine(carpim);

        }

        public void Bol(int sayi1, int sayi2)
        {
            double bolum = sayi1 / sayi2;

            Console.WriteLine(bolum);

        }
    }
}
