using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "gokce", "halil", "veli", "ayşe" };
            Console.WriteLine(isimler[0]);
            // ctrL+K & ctrl+c --> satırları seç, toplu comment yap
            // ctrL+K & ctrl+u --> satırları seç, toplu uncomment yap
            //isimler[4] = "ilker"; --- bu hata verir, o yüzden collections kullanılır
            //Console.WriteLine(isimler[4]);

            //referans tipler hem stack hem heap kullanır
            //string[] isimler = new string[] { "gokce", "halil", "veli", "ayşe" };
            //     stack            heap

            //isimler = new string[5]; --> bu şekilde yazıldığında heap'teki isimlerin adresi değişir,
            //isimler[4] = "ilker"; --- bu atama yapılırsa listedeki tüm isimler eski adreste kalacağıiçin
            //                          4 numarlı alan dışındaki her yer null olur
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 =  new List<string> { "gokce", "halil", "veli", "ayşe" };

            Console.WriteLine(isimler2[0]);

            isimler2.Add("ilker");

            Console.WriteLine(isimler2[4]);

        }
    }
}
