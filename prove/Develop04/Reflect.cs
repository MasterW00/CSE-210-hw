class Reflect : Activity
{
    List<string> _prompts = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    List<string> _following = new List<string>(){"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    public Reflect(int delay):base(delay){
        _description = "This is an Excercise where you will reflect on an experiance using the given prompts.\nYou will be able to center yourself and be awarae of who you are";
    }
   
    public void Start(){
        PromptStart($"Enter a number at least {_delay} seconds: ");
        int cycles = _duration/_delay;
        string prompt = ChooseRandomPrompt(_prompts);
        for(int i = 0; i < cycles; i++){
            LoadAnimation($"{prompt}\n{ChooseRandomPrompt(_following)}");
        }
        Console.WriteLine($"");
        PromptEnd();
    }
}