using System;

namespace CreateClass
{
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
            return $"Name: {Name}, Birthday: {BirthDate.ToLongDateString()}.";
        }
    }
}
