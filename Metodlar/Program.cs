using System;


namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakir ";

            Urun[] urunler = new Urun[] {urun1, urun2};
            //java tip güvenlidir. type safe
            //veri tipini yazman gerekiyor
            //foreach(var urun in urunler) bu şekilde yazılınca arka planda var olan urun tipine dönüştürülür

            foreach (Urun urun in urunler)
            {//urunler arrayinin hepsini tek tek gez

                //html <li> ----liste elemanı demek

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }

            //yeni bir sayfada olduğumuzu farzediyoruz
            //cw tab tab --> Console.WriteLine(); kısayol
            Console.WriteLine("------------metodlar-------------");

            //instance class örneği oluşturma
            //reusability of method -- tekrar tekrar kullanabilme özelliği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);// urunler[0]);
            //sepetManager.Ekle();//sayfa1
            //sepetManager.Ekle();//sayfa2
            sepetManager.Ekle(urun2);//urunler[1]);//sayfa3....
            //Console.WriteLine();

            sepetManager.Ekle2("armut", "yeşil armut", 12,1);
            sepetManager.Ekle2("elma", "yeşil elma", 12,23);
            sepetManager.Ekle2("karpuz", "diyarbakır ", 12,33);

            //!!!!!!encapsulation örneği !!!!!!!!!!!
            //kalan stok adedi gösterilmek istensin, ekle2 methodu önceki hali:
            //public void Ekle2(string urunAdi, string aciklama, double fiyat)
            //sepetManager.Ekle2("armut", "yeşil armut", 12);
            // şöyle değişmeli:
            //public void Ekle2(string urunAdi, string aciklama, double fiyat, int kalanAdet)
            //sepetManager.Ekle2("karpuz", "diyarbakır ", 12,22);
            /* bu methodun kullanıldığı tüm sayfalar method değiştiğinde patlar. 
              
             * fakat class kullanılarak yazılan sepetManager.Ekle methodu için sadece classta değişiklik yapılacak.
             *  public int StokAdedi { get; set; } ekleniyor urun classına
             *  bu eklendiğinde sepetManager.Ekle methodu kullanılan sayfalar patlamıyor.
             *  eğer kalan stok adedi gösterilmek istenirse classta değişiklik yapıldıktan sonra
                public int StokAdedi { get; set; } methodunda return değeri veya consoleoutput'ta yazılan kısım değiştirilir.
             */
        }
    }
    
}
