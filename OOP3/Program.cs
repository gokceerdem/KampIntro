using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKredisi = new IhtiyacKredisi();
           // ihtiyacKredisi.Hesapla();

            IKrediManager tasitKredisi = new TasitKredisi();
            //tasitKredisi.Hesapla();

            //KonutKredisi konutKredisi = new KonutKredisi(); böyle de olur
            IKrediManager konutKredisi = new KonutKredisi();
            //konutKredisi.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKredisi);
        }
    }
}
