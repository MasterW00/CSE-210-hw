using System;

class Program
{
    static void WelcomeMessage(){
        Console.WriteLine($"Welcome to this pointless program written in C#");
    }
    static string EnterUser(){
        Console.Write($"Enter Your Username:");
        return Console.ReadLine();
    }
        static int EnterUserNumber(){
        Console.Write($"Enter a User Number:");
        return int.Parse(Console.ReadLine());
    }

    static int GetSquared(int num){
        return num*num;
    }
    static void DisplayUserandNumber(string user, int num){
        Console.WriteLine($"{user} your number is {num}");
    }
    static void Main(string[] args)
    {
        WelcomeMessage();
        string user = EnterUser();
        int num = EnterUserNumber();
        num = GetSquared(num);
        DisplayUserandNumber(user, num);
        Console.WriteLine("");
    }
}
// For this assignment, write a C# program that has several simple functions:
// DisplayWelcome - Displays the message, "Welcome to the Program!"
// PromptUserName - Asks for and returns the user's name (as a string)
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name and the squared number and displays them.