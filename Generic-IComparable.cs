using System;
using System.Collections;

namespace ConsoleApp1
{
    public class BookList
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }
        public int this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            //this should have atleast one accessor
            get
            {
                throw new NotImplementedException();
            }
        }
    }
    public class Utilities<T> where T : IComparable
    {
        //where T: IComparable
        // where T: Product
        // where T : struct
        // where T : class
        // where T : new();
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
