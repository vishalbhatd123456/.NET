using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace _net
{
    class Program
    {
        static Dictionary<int, int> items = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            
            //Two seperate threads
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));

            thread1.Start();
            thread2.Start();
            
        }
        static void AddItem(){
            items.Add(1,2);
            Console.WriteLine(items.Count);
        }
}
}
