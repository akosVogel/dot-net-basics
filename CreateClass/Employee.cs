using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room Room { get; set; }

        public Employee(string name, DateTime birthDate) : base(name, birthDate)
        {
        }

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nProfession: {Profession}, Salary: {Salary}$\nRoom: {Room.Number}";
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        #region SimpleMemberwiseClone
        //public object Clone()
        //{
        //    return MemberwiseClone();
        //} 
        #endregion
    }
}
