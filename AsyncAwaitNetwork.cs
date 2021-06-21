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

            Console.WriteLine("Downloading File...");
            Download();
            Console.ReadLine();
        }
        static async void Download(){
           await Network.Download(); //execution returns to the next line
           Console.WriteLine("Download Complete ...!");
        }
    }
class Network{
    static public Task Download(){
        return Task.Run(() => Thread.Sleep(3000));
    }
}

}

