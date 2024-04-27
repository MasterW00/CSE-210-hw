using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name\n>");
        String first = Console.ReadLine();
        Console.Write("What is your last name?\n>");
        String last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}