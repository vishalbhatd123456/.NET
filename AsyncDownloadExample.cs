using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

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
            Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete!");
            });
        }
}
}

