using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Musteri musteri1 = new Musteri();

            musteri1.Adi = "xxxx";
            musteri1.Soyadi = "yyyy";
            musteri1.Id = 1;
            musteri1.TcNo = "34783209173";
            musteri1.MusteriNo = "12345";
            musteri1.SirketAdi = "?";

            //Gerçek müşteri - Tüzel müşteri
            //SOLID yazılım geliştirme prensibi
            //birbirine benzeyen objelerde inheritance yapma!!!
            //birbirlerine benzemeleri aynı classta olmaları anlamına gelmez
            */

            GercekMusteri musteri1 = new GercekMusteri();
            
            musteri1.Adi = "xxxx";
            musteri1.Soyadi = "yyyy";
            musteri1.Id = 1;
            musteri1.TcNo = "34783209173";
            musteri1.MusteriNo = "12345";

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;
            musteri2.SirketAdi = "ttt aaa vvvv";
            musteri2.MusteriNo = "357894";
            musteri2.VergiNo = "28479233";

            //müşteri classı hem gerçek hem de tüzel müşterinin referanslarını tutabiliyor
            Musteri musteri3 = new GercekMusteri(); //new = refno oluşturur
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}
