using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "c#";
            Kurs1.Egitmen = "xxx";
            Kurs1.IzlenmeOrani = 86;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "c++";
            Kurs2.Egitmen = "aaaaaaa";
            Kurs2.IzlenmeOrani = 72;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "java";
            Kurs3.Egitmen = "gökçe";
            Kurs3.IzlenmeOrani = 35;

            Kurs Kurs4 = new Kurs();
            Kurs4.KursAdi = "python";
            Kurs4.Egitmen = "murat";
            Kurs4.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { Kurs1, Kurs2, Kurs3, Kurs4 };

            foreach (Kurs kurs in kurslar) //foreach yaz tab tab (var kurs,....) şeklinde de olur
            {
                Console.WriteLine(kurs.KursAdi+ ":" + kurs.Egitmen );
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; } //bu satırı otomatik oluşturmak için prop yaz +tab+tab tuşu
        public string Egitmen { get; set; }
        public object IzlenmeOrani { get; set; }

    }
}
