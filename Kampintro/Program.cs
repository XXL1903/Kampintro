using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği- C# mutlaka değişken tipi tanımlanmalıdır.
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, allias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
