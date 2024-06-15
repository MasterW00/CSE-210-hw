using System.Diagnostics;
class Breathe : Activity
{
    string _textAnim1 = "            __________       \n        _-\"\"          \"\"-_   \n      /'                  '\\ \n     |                      |\n     |'  .--.       .--.   '|\n     |    (0)   |   (0)     |\n     |         /            |\n     |       (´__           |\n      |                    | \n      |                    | \n       \\     ```````\\     /  \n        \\    ------'     /    \n\n           '---____---'";
    string _textAnim2 = "            __________       \n        _-\"\"          \"\"-_   \n      /'                  '\\ \n     |                      |\n     |   .--.       .--.    |\n     |    (0)   |   (0)     |\n     |         /            |\n     |       (´__           |\n      |                    | \n      |                    | \n       \\     `_`_`_\\      /   \n         \\_            _/    \n           '---____---'";
    string _textAnim3 = "            __________       \n        _-\"\"          \"\"-_   \n      /'                  '\\ \n     |                      |\n     |   .--.       .--.    |\n     |    (0)   |   (0)     |\n     |         /            |\n     |       (´__           |\n      |                    | \n      |                    | \n       \\      O  `,       /  \n         \\_            _/    \n           '---____---'";
    string _textAnim4 = "            __________       \n        _-\"\"          \"\"-_   \n      /'                  '\\ \n     |                      |\n     |   .--.       .--.    |\n     |    (0)   |   (0)     |\n     |         /            |\n     |       (´__           |\n      |                    | \n      |                    | \n       \\     '-____-'     /  \n         \\_            _/    \n           '---____---'";
    public Breathe(string desc, int delay):base(desc, delay){
    }
    public Breathe(int delay):base(delay){
        _description = "This is a breathing excercise for you to allow yourself a break and clear your head";
    }
    public void Start(){
        PromptStart($"Enter a number at least {_delay * 2} seconds: ");
        int cycles = _duration / (2 * _delay);
        for(int i = 0; i < cycles; i++){
            BreathAnimation("Inhale", true);
            BreathAnimation("Exhale", false);
        }
        Console.Clear();
        Console.WriteLine($"{_textAnim4}");
        PromptEnd();
    }
    private void BreathAnimation(string message, bool inhale){
        int flip = _delay/2;
        int frame = 0;
        List<string> animation;
        if(!inhale) {animation = new List<string>(){_textAnim2, _textAnim3};}
        else {animation = new List<string>(){_textAnim2, _textAnim1};}
        for(int i = 0; i < _delay; i++){
            Console.Clear();
            Console.WriteLine($"{message}");
            Console.WriteLine($"{_delay - i}...");
            if( 0 <= (i - (flip * (frame + 1)))){
                frame ++;
            }
            Console.WriteLine($"{animation[frame]}");
            Thread.Sleep(1000);
        }
    }
    
}