using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }

            Console.ReadKey();
        }
    }
}
