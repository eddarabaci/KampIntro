using System;
using System.Collections.Generic;

namespace GenericsDemoBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Deneme");
            Console.WriteLine("Sehirler = " + sehirler.Count);

            MyList<String> sehirler2 = new MyList<String>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Eskişehir");
            Console.WriteLine("Sehirler2 = " + sehirler2.Count);
            

        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList() 
        {
            _array = new T[0];
        }

        public void Add(T item) 
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}

