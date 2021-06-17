using System;
using System.Collections.Generic;
using System.Collections;

namespace _net
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(); //non-generic class
            al.Add("Random String ....");
            al.Add("Custom String ....");

            foreach(object item in al){
                Console.WriteLine(item);
            }

           String s = (String) al[0];
            
        }
}
}
