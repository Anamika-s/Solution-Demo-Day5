namespace AbstarctClass_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sqaure sqaure = new Sqaure();
            //sqaure.GetDimensions();
            //sqaure.CalcuateArea();
            //sqaure.DisplayArea();

            //Rectangl rectangl = new Rectangl();
            //rectangl.GetDimensions();
            //rectangl.CalculateArea  ();
            //rectangl.DisplayArea();
            Shape shape = new Square();
            shape.GetDimensions();
            shape.CalculateArea();
            shape.DisplayArea();

            shape = new Rectangl();
            shape.GetDimensions();
            shape.CalculateArea();
            shape.DisplayArea();
        }
    }
}