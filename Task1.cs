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
        public static void Main(string[] args)
        {
            for(int i = 0;i <50;i++){
            Thread myThread = new Thread(new ThreadStart(work));
            myThread.Start();

            Task.Run(() => {
                Console.WriteLine("statrting In task..."+Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(3000);
                Console.WriteLine("task completed...!");
            });
            
            }
            
            Console.ReadLine();
        }
        static void work(){
            Console.WriteLine("starting thread..."+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Work Completed...!");
        }
    }
}

