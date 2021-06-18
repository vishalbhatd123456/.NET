using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace _net
{
    class Program
    {
        public static void Main(string[] args){

            CarColor car1 = CarColor.Blue;
            PainCar(car1);

            Console.ReadLine();
           
           
    }
    enum CarColor : byte {
        Orange = 1,
        Blue,
        Green,
        Red,
        Yellow
    }

    static void PainCar(CarColor cc){
        Console.WriteLine("The car was painted {0} with the code {1}", cc, (int) cc);
    }

    
}
}
