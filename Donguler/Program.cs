using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılımcı geliştirme prg";
            string kurs2 = "prg başlangıç için giriş";
            string kurs3 = "java";
            //array-dizi
            string[] kurslar = new string[] { "yazılımcı geliştirme prg", "prg başlangıç için giriş", "java"};
            //Console.WriteLine("Hello World!");
            string[] kurslargokce = new string[] { kurs1, kurs2, kurs3 };

            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for loop bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
