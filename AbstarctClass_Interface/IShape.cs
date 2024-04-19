using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClass_Interface
{
    internal interface IShape
    {
        void GetDiemnsions();
        void CalculateArea();
        void DisplayArea();
    }

    class Squ : IShape
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDiemnsions()
        {
            throw new NotImplementedException();
        }
    }

    class Rec : IShape
    {
        void IShape.CalculateArea()
        {
            throw new NotImplementedException();
        }

        void IShape.DisplayArea()
        {
            throw new NotImplementedException();
        }

        void IShape.GetDiemnsions()
        {
            throw new NotImplementedException();
        }
    }

    // interface can be used to acheive multiple inheritance

    interface I1
    {
        public void GetA();
        public void GetB();
    }
    interface I2
    {
        public void GetC();
        public void GetD();
        public void GetA();
    }
    // Multiple Inheritance acheived thru interfaces
    class C1 : I1, I2
    {
        public void GetA()
        {
            throw new NotImplementedException();
        }

        public void GetB()
        {
            throw new NotImplementedException();
        }

        public void GetC()
        {
            throw new NotImplementedException();
        }

        public void GetD()
        {
            throw new NotImplementedException();
        }
    }

    interface I10
    {
        public void GetA() { }

    }
}
