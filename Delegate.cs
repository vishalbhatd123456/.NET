using System;
using System.Collections;

delegate int NumberChange(int n);
namespace ConsoleApp1
{

    class TestDelegate
    {
        static int number = 10;
        public static int AddNum(int p)
        {
            number += p;
            return number;
        }
        public static int MultNum(int p)
        {
            number *= p;
            return number;
        }
        public static int getNum()
        {
            return number;
        }

        class Program
        {
            static void Main(string[] args)
            {
                NumberChange nc1 = new NumberChange(AddNum);
                NumberChange nc2 = new NumberChange(MultNum);

                nc1(25);
                Console.WriteLine("Value of Num:{0}",getNum());
                nc2(5);
                Console.WriteLine("Value of Num:{0}",getNum());
                Console.ReadKey();
            }
        }
    }
}
