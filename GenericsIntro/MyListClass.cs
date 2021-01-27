using System;
namespace GenericsIntro
{
    public class MyListClass<T>
    {//çalışılacak özel bir tip olacağı için T (type) yazılır
        T[] items;

        //constructor : ct + tab + tab

        public MyListClass()
        {//constructor of this class
            items = new T[0];//sıfır elemanlı referans tipi array oluştur
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            //for + tab+ tab döngü oluşturur
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
        
    }
}
