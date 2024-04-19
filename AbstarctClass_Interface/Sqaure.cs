using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClass_Interface
{
    internal class Sqaure
    {
        int side;
        float area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter value of side");
            side = byte.Parse(Console.ReadLine());
        }
        public void CalcuateArea()
        {
            area = side * side;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    internal class Rectangle
    {
        int length, width;
        float area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter value of length");
            length = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter value of width");
            width = byte.Parse(Console.ReadLine());
        }
        public void CalcuateArea()
        {
            area = length * width;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }


    internal class Triangle
    {
        int Base, height;
        float area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter value of Base");
            Base = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter value of height");
            height = byte.Parse(Console.ReadLine());
        }
        public void CalcuateArea()
        {
            area = (float).5* Base * height;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
}
