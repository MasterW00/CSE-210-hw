using System;
class Program
{
    static void Main(string[] args)
    {   
        
        Scripture first = PromptScripture();
        StartHideGame(first);
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
    static Scripture PromptScripture(){
        string book = "";
        while(true){
            Console.WriteLine("Please pick a Book from the standard works to load:");
            book = Console.ReadLine().ToLower();
            if(book.Contains("old")) book = "OldTestament";
            else if(book.Contains("new")) book = "NewTestament";
            else if(book.Contains("mormon")) book = "BookOfMormon";
            else if(book.Contains("doctrine")) book = "DoctrineAndCovenants";//unfinished
            else if(book.Contains("pearl")) book = "PearlOfGreatPrice";
            else{
                book = book = "BookOfMormon";
                Console.WriteLine($"Could not find the book you were looking for");
                continue;
            }
            break;
        }
        Console.WriteLine("Enter the reference for the scripture {book} {chapter}:{verse}-(verse) :");
        string reference = Console.ReadLine();
        string section = reference.Split(' ')[0];
        int chapter = int.Parse(reference.Split(' ')[1].Split(':')[0]);
        int verse = int.Parse(reference.Split(' ')[1].Split(':')[1].Split('-')[0]);
        int endverse;
        try{endverse = int.Parse(reference.Split(' ')[1].Split(':')[1].Split('-')[1]);}
        catch(IndexOutOfRangeException){endverse = -1;}
        if(endverse == -1) return new Scripture(book, section, chapter, verse);
        return new Scripture(book, section, chapter, verse, endverse);
    }
    static void StartHideGame(Scripture first){
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
}