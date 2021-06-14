using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = true;
            SmallApartment mySmallApartment = new SmallApartment();
            Person myPerson = new Person();
            myPerson.Name = "Whitney";
            myPerson.House = mySmallApartment;
            myPerson.ShowDate();
            if (debug)
            {
                Console.ReadLine();
            }
        }
    }
}
