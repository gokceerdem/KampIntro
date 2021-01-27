using System;
namespace OOP1
{
    public class Product    //entity=varlık
    {
        //bu tip classlarda sadece özellik olur
        //crud operasyonları : create read update delete
        public int Id { get; set; } //primary key
        public int CategoryId { get; set; } //foreign key
        //yazımın düzenli olması için kodlamada önce primary key sonra foreign key yazılır
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
