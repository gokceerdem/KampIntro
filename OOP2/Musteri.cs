using System;
namespace OOP2
{
    class Musteri
    {
        //musteri classı generic bir class, parent class
        //gerçek müşteri tüzel müşteri musteri classının extention'ı
        //
        public int Id { get; set; }

        public string MusteriNo { get; set; }


        /*public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string SirketAdi { get; set; }

        public string TcNo { get; set; } //bir veri üzerinde matematiksel işlem yapılmıyorsa
                                         //bu verileri string varchar char olarak tanımlanırsa
                                         //diğer sistemlerle entegre olması durumunda kolaylık sağlanır
                                         //eğer bir nesnede bir değeri kullanmak zorunda değilmiş gibi duruyorsan
                                         //o nesnede soyutlama hatası yapılıyor demektir
                                         //yani bir müşteri gerçekse şirket adı yoktur
                                         //tüzelse adı soyadı kısmı kullanılmaz
                                         //bu yüzden bu iki müşteri kavramı ayrıştırılmalıdır
        public string VergiNo { get; set; } //vergino sadece tüzel müşteriye ait
        */
        }
}
