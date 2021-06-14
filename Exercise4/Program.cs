using System;

namespace Exercise4
{
    class Program
    {
        
    }
    class Person
    {
        public int Age { get; set; }

        public void SetAge(int n)
        {
            Age = n;
        }
    }
    class Student : Person
    {
        public void GoToSchool()
        {
            Console.WriteLine("I'm going to school");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", Age);
        }
    }
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explaination begins");
        }
    }
}
