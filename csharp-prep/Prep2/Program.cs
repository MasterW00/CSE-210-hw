using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your Percentile grade?\n>");
        var grade = Console.Read();
        char letter;
        if (grade >= 90) letter = 'A';
        else if (grade >= 80) letter = 'B';
        else if (grade >= 70) letter = 'C';
        else if (grade >= 60) letter ='D';
        else letter = 'F';

        Console.WriteLine($"Your letter Grade {letter}");
        
    }
}