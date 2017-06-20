using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var atesz = new Person("Atesz", new DateTime(1989,5,6));
            Console.WriteLine(atesz);

            var ateszTheProgrammer = new Employee("ngAtesz", new DateTime(1989, 5, 6));
            ateszTheProgrammer.Salary = 100000;
            ateszTheProgrammer.Profession = "Software engineer";
            Console.WriteLine(ateszTheProgrammer);
        }
    }
}
