using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.getRectangle();
            Calculate(rectangle);
            Circle circle = new Circle();
            circle.getCircle();
            Calculate(circle);
        }
        public static void Calculate(Shape1 S)
        {
            Console.WriteLine("Area: {0}", S.Area());
            Console.WriteLine("Circumference: {0}", S.Circumference());
        }

    }
}
