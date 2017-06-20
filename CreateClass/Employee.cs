using System;

namespace CreateClass
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public readonly Room MyRoom = new Room(42);

        public Employee(string name, DateTime birthDate) : base(name, birthDate)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"\nProfession: {Profession}, Salary: {Salary}$";
        }
    }
}
