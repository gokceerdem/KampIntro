using System;
namespace OOP3
{
     class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //burada çeşitli bilgiler alınır
            //başvuran bilgileri değerlendirme
            //kredi hesaplama
            // başvuruyu hangi krediye göre yapman gerekiyor diye bakmak için parametre geçirilir
            //IKrediManager generic implementasyon classı olduğu için
            //bu kısımda taşıt, ihtiyaç, konut kredisi.. istenen kredi tipi geçirilebilir
            krediManager.Hesapla();

         }
    }
}
