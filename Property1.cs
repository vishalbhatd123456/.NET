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
        class Player{
public bool IsAlive {
    get {return health > 0;}
}
int health = 100;

public void Hit(){
    Random r = new Random();
    health-=r.Next(5,50);
    }



}
        public static void Main(string[] args){

            Player player = new Player();
           // player.IsAlive = true;- error - property is readonly
            for(int i = 0;i < 20;i++){
                player.Hit();
                Console.WriteLine("Is player alive:"+player.IsAlive);
            }
        }
    }
}

