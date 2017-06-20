using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var atesz = new Person("Atesz", new DateTime(1989,5,6));
            Console.WriteLine(atesz);

        }
    }

    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public enum Gender
        {
            Male,
            Female
        }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"My name is {Name} and I was born in {BirthDate.Year}.";
        }
    }
}
