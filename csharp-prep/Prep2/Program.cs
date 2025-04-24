using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int x = int.Parse(valueFromUser);
        string letter = "";
        string pass = "";
        string sign = "";
        if (x >= 93)
        {
            letter = "A";
        }
        else if (x < 90 && x >= 80)
        {
            letter = "B";
        }
        else if (x < 80 && x >= 70)
        {
            letter = "C";
        }
        else if (x < 70 && x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (x > 70)
        {
            pass = "Congradulations you passed the class!";
        }
        else
        {
            pass = "Sorry better luck next time:(";
        }
        Console.WriteLine($"Your grade is {letter} :{pass}");
    }
}