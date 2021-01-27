using System;
namespace OOP1
{
    public class ProductManager //mamager gibi isimlendirmeler ürünle ilgili operasyonel uygulamaların olacağı zaman kullanılır
    {
        //operasyonle işlemler genelde emir kipleri ile yazılır
        public void Add(Product product)
        {//encapsulation
         //  product.ProductName = "kamera"; //isim kısmına atama yapar
            Console.WriteLine(product.ProductName + " eklendi.");

        }
        public void Update(Product product)
        {//encapsulation
         //  product.ProductName = "kamera"; //isim kısmına atama yapar
            Console.WriteLine(product.ProductName + " güncellendi.");

        }
        /* public void BiseyYap(int k)
         {
             k = 9009;
         }*/

        public int Topla(int say1,int say2)
        {
            return say1 + say2;
        }
    }
}
