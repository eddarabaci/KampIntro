using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<T>
    {
        T[] items;
        T[] tempItems;

        public MyDictionary() 
        {
            items = new T[0];
        }

        public void Add(T item) 
        {
            tempItems = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            Console.WriteLine("Eklendi!!");

        }


        public int Count
        {
            get { return items.Length; }
        }


    }
}
