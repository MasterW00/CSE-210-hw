using System;
using System.IO;
class Program
{
    public static Date today;
    static int read_int(){
        try{
            return int.Parse(Console.ReadLine());
        }
        catch(FormatException){
            Console.WriteLine("Please enter a number");
            return read_int();
        }

    }
    static void Main(string[] args)
    {   
        WelcomeMessage();
        Console.WriteLine($"What is todays date?");
        today = prompt_user_date();
        while(true){
            user_menu();
        }
    }

    static void WelcomeMessage(){
        Console.WriteLine("Welcome to your journal");
    }
    static void prompt_save_journal(){
        Console.WriteLine($"What is the name of this journal?");
        Console.Write($">");
        string name = Console.ReadLine();
        Journal.save_journal(name);
    }
    static void prompt_load_journal(){
         bool merge = false;
        Console.WriteLine($"What is the name of your journal?");
        Console.Write($">");
        string name = Console.ReadLine();
        if (Journal.entries.Count > 0){
            Console.WriteLine($"Would you like to save exiting entries into the existing journal?\n(loading a jounral without saving will erase your entries)");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write($">");
            switch(read_int()){
                case 1:
                    merge = true;
                    break;
                case 2:
                    merge = false;
                    break;
            }
        }
        Journal.load_journal(name, merge);
    }
    static void user_menu(){
        Console.WriteLine($"");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Save Journal");
        Console.WriteLine("2. Load Journal");
        Console.WriteLine("3. Add Entry");
        Console.WriteLine("4. Remove Entry");
        Console.WriteLine("5. Display Entries");
        Console.WriteLine("6. Get a Prompt");
        Console.WriteLine($"7. Change Date");
        Console.WriteLine("8. Quit"); Console.Write(">");
        switch (read_int()){
            case 1:
                prompt_save_journal();
                break;
            case 2:
                try{
                    prompt_load_journal();
                    Console.WriteLine($"Journal Loaded!");
                }
                catch(FileNotFoundException){
                    Console.WriteLine("!! I could not find your journal !!");
                }
                break;
            case 3:
                prompt_user_entry();
                break;
            case 4://remove entry
                Console.WriteLine($"What date would you like to remove, leave blank for today? (M/D/Y):");
                string input = Console.ReadLine();
                if(input == "") Journal.Remove(today);
                
                Journal.Remove(input);
                break;
            case 5:
                Journal.Display();
                break;
            case 6://get a prompt
                Journal.give_me_a_prompt();
                prompt_user_entry();
                break;
            case 7:
                Console.WriteLine($"What date would you like to change to?");
                today = prompt_user_date();
                break;
            case 8://quit
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
    static void prompt_user_entry(){
        
        Console.WriteLine($"Make an entry for your journal:");
        Entry entry = new Entry(today, Console.ReadLine());
        Journal.add(entry);
        Journal.Display();
    }
    static Date prompt_user_date(){
        Console.Write($"Year: ");
        int year = read_int();
        Console.Write($"Month: ");
        int month = read_int();
        Console.Write($"Day: ");
        int day = read_int();
        return new Date(year, month, day);
    }
}