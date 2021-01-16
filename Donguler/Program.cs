using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlamaya başlangıç için kurs","java","Python","C#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //foreach dizi temelli yapıları tek tek döner. For döngüsüne gerek yok. Buradaki kurs un kurslar ile alakası yok istedğin değişken adını verebilirsin.
            Console.WriteLine("for bitti.");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - Footer");
        }
    }
}
