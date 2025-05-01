using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int n = int.Parse(number);
        int sq = n * n;
        Console.Write($"{name}, the square of your number is {sq}.");
    }
}