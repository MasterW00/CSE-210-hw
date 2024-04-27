using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your Percentile grade?\n>");
        int grade = int.Parse(Console.ReadLine());
        String letter;
        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";
        if ((grade % 10) >= 7 || grade == 100){
            letter = "+" + letter;
        }
        else if((grade % 10) < 3){
            letter = "-" + letter;
        }
        Console.WriteLine($"Your letter Grade {letter}");
        if (grade >= 70) Console.WriteLine($"PASSED! You're so good at school and tests!");
        else Console.WriteLine($"You just need to try again. right? -\\_(7_7)_/-");
        
        
    }
}