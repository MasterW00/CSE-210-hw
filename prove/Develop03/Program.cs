using System;
class Program
{
    static void Main(string[] args)
    {
        Scripture first = new Scripture("NewTestament", "2 Peter", 2, 12);
        Standard_Works.findVerse(first);
        bool x = true;
        first.printScripture();
        string[] scripture = first.getText().Split(' ');
        while(x){
            scripture = hideWords(scripture, 5);
        x = false;
        foreach(string s in scripture) {
            if(!s.Contains('_')) x = true;
        }
            if (Console.ReadLine().Contains('q')) break;
            Console.Clear();
            Console.WriteLine($"{string.Join(' ', scripture)}");
        }
    }
    public static string[] hideWords(string[] scripture_redacted, int number){
        Random random = new Random();
        int rand;
        for(int i = 0; i < number; i++){
            rand = random.Next(0, scripture_redacted.Length - 1);
            int x = scripture_redacted.Length;
            while(scripture_redacted[rand].Contains('_') && x > -1 ){
                if (rand++ >= scripture_redacted.Length - 1){
                    rand = 0;
                }
                x--;
            }
            scripture_redacted[rand] = new string('_', scripture_redacted[rand].Length);
        }
        return scripture_redacted;
        
    }
}

// public class Book{
//     public string title;
// }
