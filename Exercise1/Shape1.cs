using System;
namespace Exercise1
{
    abstract class Shape1
    {
        protected float R, L, B;
        public abstract float Area();
        public abstract float Circumference();
        
    }

    class Rectangle : Shape1
    {
        public void getRectangle()
        {
            Console.WriteLine("Enter the Length of Rectangle:");
            L = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the Rectangle:");
            B = (float)Convert.ToDouble(Console.ReadLine());
        }
        public override float Area()
        {
            return L * B;
        }
        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }

    class Circle : Shape1
    {
        public static float pi = 3.14f;
        public void getCircle()
        {
            Console.WriteLine("Enter the radiue of the Circle:");
            R = (float)Convert.ToDouble(Console.ReadLine());
        }
        public override float Area()
        {
            return R * R * pi;
        }
        public override float Circumference()
        {
            return 2 * R * pi;
        }
    }

}
