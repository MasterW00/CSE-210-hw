using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Learning04 World!");
        Assignments one = new Assignments("Jared", "Classes in C#");
        MathAssignments two = new MathAssignments("Greg", "Math", "2.3", "20-299");
        WritingAssignments three = new WritingAssignments("Sarah", "Cretive Writing", "The Purpous of life wasn't 42");
        Console.WriteLine(one.GetSummary());
        Console.WriteLine($"");
        Console.WriteLine(two.GetHomeworkList());
        Console.WriteLine($"");
        Console.WriteLine(three.GetWritingInformation());
        Console.WriteLine($"");
    }
}