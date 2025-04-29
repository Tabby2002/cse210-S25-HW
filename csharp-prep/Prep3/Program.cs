using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    { 
        //Console.Write("What is the magic number? ");
        //string valueFromUser = Console.ReadLine();
        //int x = int.Parse(valueFromUser);
        //int y = -1;
        
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 100);
        int y = -1;

        while (x != y)
        {
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        y = int.Parse(guess);
        if (x == y)
        {
            Console.Write("You guessed it.");
        }
        else if (x < y)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Higher");
        }
        
        }       
    }
}