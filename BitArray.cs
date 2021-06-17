using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace _net
{
    class Program
    {
        public static void Main(string[] args){

            bool[] preload = new bool[3]{true,false, true};
            BitArray enemyGrid = new BitArray(3);

            enemyGrid[0] = false;
            enemyGrid[1]= true;
            enemyGrid[2] = false;

            Console.WriteLine(enemyGrid);
        }
    }
}
