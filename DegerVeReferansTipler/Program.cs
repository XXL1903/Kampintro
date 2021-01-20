using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //int, decimal, float, double, bool = Değer Tip ===> Hafızada Stack olarak kaydolur. Stack işlemi işlem yapıldığı anda işlemi yapıp bağlantıyı koparır. (Bilgisayarın RAM 'i gibi)
            //array, class, interface = Referans Tip ===> Hafızada Heap olarak kaydolur.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            ///sayi1 ?? ===>30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]  ??  ===>999

            //bellek işlemleri sırasında int[] sayilar1 kısmına kadar stack olarak kaydeder. new deyince ise heap de bir array kaydeder ve bunun adresi olur. Mesela 101 olsun. Dolayısıyla Stack olan Sayilar1 in karşılığı [10, 20, 30] olur. Sayilar2 içinde aynı işlem yapılır. Onun da bellek adresi 102 diyelim. Eğer sayilar1=sayilar2 diyince ise sayilar 1 in adresini 102 olarak değiştirir. Dolayısıylar sayilar1 in önceki heap karşılığı olan [100,200,300] değeri çöp olur. eğer 102 belleğinde değişiklik olur ise heranda sayilar1 i de etkilemeye devam eder.


            
        }
    }
}
