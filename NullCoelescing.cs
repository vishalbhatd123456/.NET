using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace _net
{
    class Person{
        public string Name {get; set;}
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Person person = new Person(){
            //     Name = "Tim"
            // };
            Person person = new Person();
            Console.WriteLine(person?.Name??"not set");
          
        }
}
}

