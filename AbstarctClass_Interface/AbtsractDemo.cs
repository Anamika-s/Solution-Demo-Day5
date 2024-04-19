using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClass_Interface
{
    internal abstract class Shape
    {
        protected float area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    class Square : Shape
    {
        int side;
        public override void CalculateArea()
        {
            area = side * side;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter value of side");
            side = byte.Parse(Console.ReadLine());
            throw new NotImplementedException();
        }
    }

    class Rectangl : Shape
    {
        int length, width;
        public override void CalculateArea()
        {
            area = length * width;
        }
        public override void GetDimensions()
        {
            Console.WriteLine("Enter value of length");
            length = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter value of width");
            width = byte.Parse(Console.ReadLine());

        }
    }

}
