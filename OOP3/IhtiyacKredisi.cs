using System;
namespace OOP3
{
    class IhtiyacKredisi : IKrediManager
    {
        public IhtiyacKredisi()
        {
        }

        public void DoSmth()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("IhtiyacKredisi ödeme planı hesaplandı");
        }
    }
}
