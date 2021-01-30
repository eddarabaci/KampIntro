using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<String> brands = new MyDictionary<String>();
            Console.WriteLine("Previous Count : "+brands.Count);
            brands.Add("Mercedes");
            Console.WriteLine("Current Count : "+brands.Count);

        }
    }
}
