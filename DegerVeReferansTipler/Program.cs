using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;//sayı1'in değeri eşittir sayı2'nin değeri
            sayi2 = 65;

            Console.WriteLine(sayi1); //30 

            int[] say1 = new int[] { 10, 20, 30 };
            int[] say2 = new int[] { 100, 200, 300 };
            say1 = say2; //say1 referans no say2 referans no ya eşitledin.
            say2[0] = 999;
            Console.WriteLine(say1[0]);

            //int,decimal,float,double,bool : değer tip,
            //array,class,interface : referans tip

            //bellekte stack ve heap olarak iki alan vardır

            // değer tip olanlar sadece stackte işlenir

            //referans tip olanlar new keyword kullanınca heap'te yeni bir adres oluşturur
            //pointer
            //stack         heap
            //say1          adres:100 { 10, 20, 30 }
            //say2          adres:102 { 100, 200, 300 }

            //say1=say2 demek say1 referans no 102 yaptık demek son durum:
            //stack         heap
            //say1          adres:102 { 100, 200, 300 }
            //say2          adres:102 { 100, 200, 300 }

            //sonra say2[0] = 999
            //say1=say2 demek say1 referans no 102 yaptık demek son durum:
            //stack         heap
            //say1          adres:102 { 999, 200, 300 }
            //say2          adres:102 { 999, 200, 300 }

            //100 adresi kullanılmaz hale geldi,
            //dot net garbage collector gelip bu adresi collect eder


        }
    }
}
