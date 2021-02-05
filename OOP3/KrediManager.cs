using System;
namespace OOP3
{
    /*class KrediManager
    {
        
        public void Hesapla()
        {
             *if kreditipi = türketici
             * if else kreditipi = çiftçi
             * .....
             * end if;
             * 
             * bu  şekilde yazılırsa kod çok karmaşıklaşır.
             * bunun yerine her bir kredi tipi için yeni class oluşturulur
             
        }
      }*/
    interface IKrediManager
    {
        //interfaceler şablon demektir bu interface'i kullanan tüm objeler bu şablona uymak zorundadır
        //okunurluğu arttırmak için interface objeler I.... olarak isimlendirili
        //her kredi kullanımında olması gereken methodlar:
        void Hesapla(); //operasyonlar
        void DoSmth();
    }

}
