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
}
