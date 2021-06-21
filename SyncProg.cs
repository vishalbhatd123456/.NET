using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace _net
{
    class Program
    {
        public static void Main(string[] args){

            //asynchronous programming in .net
            
            //function to download

            Console.WriteLine("Downloading the file");
            Download();

            Console.ReadLine();

    
        }
        static void Download(){
            Thread.Sleep(3000); //console application will be made unresponsive
            Console.WriteLine("Download Complete!");
        }
}
}

