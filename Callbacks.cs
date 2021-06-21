using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace _net
{
    class Program
    {
        public static void Main(string[] args){

            Console.WriteLine("Downloading File...");
            Download();
            Console.ReadLine();
        }
        static  void Download(){
            Network.Download((message) => Console.WriteLine("Download Complete ...!"+message));
           Console.WriteLine("Download Complete ...!");
        }

       
    }
    class Network{
        public static void Download(Action<String> callback){
            Task.Run(() => {Thread.Sleep(3000);
            callback("Completed!");
            });
        }
    }

}

