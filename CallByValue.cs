using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace _net
{
    class Program
    {
        public static void Main(string[] args){

            double x = 5;
            double y = 4;
            Console.WriteLine("5+4 = {0}", GetSum(x,y));

            Console.WriteLine(" {0}",x);
            
            Console.ReadLine();
           
    }

    public static double GetSum(double x = 1, double y = 1){
        double temp = x;
        x = y;
        y = temp;

        return (x+y);
    }
}
}
