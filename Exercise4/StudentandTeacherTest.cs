using System;
namespace Exercise4
{
    public class StudentandTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Hello");
            Student student = new Student();
            Console.WriteLine("Hello");
            student.SetAge(21);
            student.ShowAge();
            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            Console.WriteLine("Hello");
            teacher.Explain();
        }
    }
}
