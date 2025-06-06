using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment();
        assign1.SetStudentName("Samuel Bennett");
        assign1.SetTopic("Multiplication");

        Assignment assign2 = new Assignment();
        assign2.SetStudentName("Roberto Rodriguez");
        assign2.SetTopic("Fractions");
        MathAssignment assign21 = new MathAssignment();
        assign21.SetTextbookSection("Section 7.3");
        assign21.SetProblems("Problems 8-9");

        Assignment assign3 = new Assignment();
        assign3.SetStudentName("Mary Waters");
        assign3.SetTopic("European History");
        WritingAssignment assign31 = new WritingAssignment();
        assign31.SetTitle("The Causes of World War II by Mary Waters");


        Console.WriteLine(assign1.GetSummary());
        
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign21.GetHomeworkList());
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign31.GetWritingInformation());
    }
}