class Activity
{
    private static string _startMessage =  "Comencing with the mindfulness Acivity...";
    private static  string _endMessage = "Thank you for Partcipating! :)";
    protected int _delay;
    protected int _duration;
    protected string _description;
    protected Activity(string desc, int delay){
        _description = desc;
        _delay = delay;
    }
    protected Activity(int delay){
        _delay = delay;
    }
    protected Activity(){
    }
    public void PromptStart(string custom){
        Console.Clear();
        Console.WriteLine(_startMessage);
        Console.WriteLine($"\n{_description}");
        Console.WriteLine($"\nHow Long would you like to excercize your mindfulness?");
        Console.Write(custom);
        _duration = int.Parse(Console.ReadLine());
    }
    public string ChooseRandomPrompt(List<string> list){
        Random rand = new Random();
        return list[rand.Next(list.Count)];
    }
    public void PromptEnd(){
        Console.WriteLine($"");
        Console.WriteLine(_endMessage);
    }
    public void Display(){

    }
    protected void LoadAnimation(string message){
    for (int i = 0; i <= _delay; i++){
        Console.Clear();
        Console.WriteLine($"{message}");
        Console.Write(" ");
        for(int a = 0; a < i; a++){
            Console.Write('█');
        }
        for(int b = 0; b < _delay -i; b++){
            Console.Write('░');
        }
        Console.Write("                 ");
        Thread.Sleep(1000);
    }
    }
    protected void CountDownAnimation(string prompt){
        for(int i = _delay; i > 0; i--){
            Console.Clear();
            Console.WriteLine($"{prompt}");
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
    }
}