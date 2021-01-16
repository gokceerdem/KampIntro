using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği olan bir dil c# ve java
            //python o kadar katı değil
            //do not repeat ypurself
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.35;
            double dolarbugun = 7.45;

            if (dolarDun > dolarbugun)
            { Console.WriteLine("Azalış butonu"); }
            else if (dolarDun < dolarbugun)
            {
                Console.WriteLine("Artış butonu"); }
            else
                Console.WriteLine("Aynı kaldı");


            if (sistemeGirisYapmisMi == true)

            { Console.WriteLine("kullanıcı menüsü"); }

            Console.WriteLine(kategoriEtiketi);
            // Console.WriteLine("Hello World!");
        }
    }
}
