using System;

namespace homeWorkRearrangementValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Cage";
            string surename = "Anna";
            string cupTea = "coffe";
            string cupCoffe = "tea";
            string temp;

            Console.WriteLine($"Name is {name}, surename is {surename}");
            Console.WriteLine($"In the cup of tea --> {cupTea}, in the cup of coffee --> {cupCoffe}");

            temp = surename;
            surename = name;
            name = temp;
            temp = cupTea;
            cupTea = cupCoffe;
            cupCoffe = temp;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Name is {name}, surename is {surename}");
            Console.WriteLine($"In the cup of tea --> {cupTea}, in the cup of coffee --> {cupCoffe}");
        }
    }
}
