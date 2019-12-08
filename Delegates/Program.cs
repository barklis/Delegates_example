using System;
using System.Threading;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            InformingList lista = new InformingList();

            lista.Add("Placki ziemniaczane");
            //Thread.Sleep(1000);
            lista.Add(3.0003);
           // Thread.Sleep(1000);
            lista.Add(true);
           // Thread.Sleep(1000);
            //lista[1] = 5.0001;
           // Thread.Sleep(1000);
            lista.Clear();
            Console.ReadKey();
        }
    }
}
