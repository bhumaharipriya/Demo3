using System;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello " + name); // concatenation
        Console.WriteLine("Hello {0}", name);// Placeholder syntax with index
        Console.WriteLine($"Hello {name}");// Placeholder syntax
    }
}
        }
    

