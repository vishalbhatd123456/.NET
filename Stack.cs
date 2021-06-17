using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace _net
{
    class Program
    {
        public static void Main(string[] args){

           Stack<String> pancakes = new Stack<string>();

           pancakes.Push("first pancakes made...");
           pancakes.Push("second pancakes made...");
           pancakes.Push("last pancakes made...");

           foreach(var pancake in pancakes){
               Console.WriteLine(pancake);
           }
        }
    }
}
