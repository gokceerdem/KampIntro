using System;
namespace Metodlar
{
     class SepetManager
    {
        public void Ekle(Urun urun) //naming convention ilk harf büyük
        {
            Console.WriteLine(urun.Adi+ " sepete eklendi xxxx");

        }

        public void Ekle2(string urunAdi,string aciklama, double fiyat, int kalanAdet)
        {
            Console.WriteLine(urunAdi + " sepete eklendi.");
        }
    }
}
