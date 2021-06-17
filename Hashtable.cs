using System;
using System.Collections.Generic;
using System.Collections;

namespace _net
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            table.Add("title","myWebsite");
            table.Add("title","myNewWebsite");

            var s = (String)table["title"];

            Console.WriteLine(s);
            
        }
}
}
