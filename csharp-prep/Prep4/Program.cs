using System;
using System.Collections.Generic; 
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int y = -1;
        while (y != 0)
        {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        y = int.Parse(number);
        if (number != "0")
        {
        numbers.Add(y);
        }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
        if (number > max)
        {
        max = number;
        }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}