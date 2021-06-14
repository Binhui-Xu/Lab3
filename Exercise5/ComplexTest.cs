using System;
namespace Exercise5
{
    public class ComplexTest
    {
        static void Main(string[] args)
        {
            bool debug = false;
            ComplexNumber number = new ComplexNumber(5,2);
            Console.WriteLine("Number is: "+number.ToString());
            number.setImaginary(-3);
            Console.WriteLine("Number is: "+number.ToString());
            Console.WriteLine("Magnitude is: ");
            Console.WriteLine(number.getMagnitude());
            ComplexNumber number2 = new ComplexNumber(-1,1);
            number.Add(number2);
            Console.WriteLine("After adding: ");
            Console.WriteLine(number.ToString());

        }
    }
}
