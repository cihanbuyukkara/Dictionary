using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1,"Cihan");
            myDictionary.Add(2,"Özge");
            myDictionary.Add(3,"Sinan");
            myDictionary.Add(4,"Yağmur");
            myDictionary.Add(5,"Ensar");

            Console.WriteLine("Count:"+myDictionary.Count);

            foreach (var values in myDictionary.Values)
            {
                Console.WriteLine("values:" + values);
            }
        }
    }
}
