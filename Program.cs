using System;

namespace AchrafProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddClass obj_1 = new AddClass();
            System.Console.WriteLine(obj_1.Add(2, 3));

            MultiplyClass obj_2 = new MultiplyClass();
            System.Console.WriteLine(obj_2.Multiply(2, 3));

        }
    }
}
