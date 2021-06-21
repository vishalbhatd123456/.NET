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
        static async void Download(){
            HttpClient client = new HttpClient();

           var data = await client.GetStringAsync("http://rouxacademy.com");
           Console.WriteLine("Download Complete ...!"+data);
        }
    }

}

