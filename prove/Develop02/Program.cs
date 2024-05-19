using System;
using System.IO;

class Program
{
    static int read_int(){
    return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {   
        WelcomeMessage();
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
        Console.WriteLine($"What is the name of your journal?");
        Console.Write($">");
        string name = Console.ReadLine();
        Journal.load_journal(name);
    }
    static void user_menu(){
        Console.WriteLine($"");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Save Journal");
        Console.WriteLine("2. Load Journal");
        Console.WriteLine("3. Add Entry");
        Console.WriteLine("4. Remove Entry");
        Console.WriteLine("5. Display Entries");
        Console.WriteLine("6. Quit"); Console.Write(">");
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
                Console.WriteLine($"What date would you like to remove? (M/D/Y):");
                Journal.Remove(Console.ReadLine());
                break;
            case 5:
                Journal.Display();
                break;
            case 6://quit
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
    static void prompt_user_entry(){
        Console.WriteLine($"What is todays date?");
        Console.Write($"Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write($"Month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write($"Day: ");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine($"Make an entry for your journal:");
        Entry entry = new Entry(new Date(year,  month, day), Console.ReadLine());
        Journal.add(entry);
        Journal.Display();
    }
}