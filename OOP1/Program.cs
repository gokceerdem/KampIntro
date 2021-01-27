using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";//tbx --> kullanıcıdan ekran vasıtasıyla veri almak
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 4, ProductName = "kalem", UnitPrice = 35 };

            //PascalCase : class için, camelCase obje için
            //devops süreçlerinde isimlendirme notasyon önemli !!!
            //c# case sensitive bir dil
            ProductManager productManager = new ProductManager();
            //intentional programming
            //ihtiyaçları varmış gibi kodlamak

            //int,double,bool...değer tip
            //diziler,class,abstract class, interface referans tip
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //ref & out keywordler
            /*örnek
            int k = 99;
            productManager.BiseyYap(k);
            Console.WriteLine(k);
            */
        }
    }
}
