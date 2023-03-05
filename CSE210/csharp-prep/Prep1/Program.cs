using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is yor first name? ");
        string name = Console.ReadLine();

        Console.Write("Whats is your lastname? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {name}");
    }
}