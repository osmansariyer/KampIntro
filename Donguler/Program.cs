using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel Kurs", "Java","C#","Phyton" };

            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("/////");
            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
