using System;
class Listen : Activity
{
    List<string> prompts = new List<string>(){"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    public Listen(){
        _description = "This is a listening excercise, write a series of short answers to the prompt pressing enter between each responce\ntill the program stops you\nI am here to listen, as you listen to yourself";
    }
    public void Start(){
        PromptStart($"Enter a number of seconds: ");
        Console.Clear();
        Console.WriteLine(ChooseRandomPrompt(prompts));
        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        int num = 0;
        while (DateTime.Now - startTime < duration){
            Console.ReadLine();
            num ++;
        }
        Console.WriteLine($"You thought of {num} things!");
        PromptEnd();

    }
}