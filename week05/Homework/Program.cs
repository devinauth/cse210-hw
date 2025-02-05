using System;

class Program
{
    static void Main()
    {
        // Devi Nauth's Assignment (Base Class)
        Assignment basicAssignment = new Assignment("Devi Nauth", "Multiplication");
        Console.WriteLine(basicAssignment.GetSummary());
        Console.WriteLine();

        // Devi Nauth's Math Assignment
        MathAssignment mathHomework = new MathAssignment("Devi Nauth", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());
        Console.WriteLine();

        // Devi Nauth's Writing Assignment
        WritingAssignment writingHomework = new WritingAssignment("Devi Nauth", "European History", "The Causes of World War II");
        Console.WriteLine(writingHomework.GetSummary());
        Console.WriteLine(writingHomework.GetWritingInformation());
    }
}

