using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Collections;


namespace ConsoleApp1
{
    public class Shape
    {
        //keynote clone
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }
    }
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
    }
    public class Circle : Shape
    {

    }
    class Program
        {
        
            static void Main(string[] args)
            {

            Text text = new Text();
            Shape shape = text;

            //shape.FontSize = 10; 
            text.FontSize = 2;
            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
            // they point to the same reference
            /*StreamReader streamReader = new StreamReader(new MemoryStream());*/

            ArrayList list = new ArrayList();
            list.Add("anyObe3cjt");
            list.Add("kANNDA");
            list.Add(1);

            var anotherList = new List<Shape>();

            Shape shapeNew = new Text();
            Text textNew = (Text)shape;

            }
       }
}

