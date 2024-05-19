using System;
using System.IO;
class Program
{
    public static Date today;
    static int readInt(){
        try{
            return int.Parse(Console.ReadLine());
        }
        catch(FormatException){
            Console.WriteLine("Please enter a number");
            return readInt();
        }
    }
    static void Main(string[] args)
    {   
        WelcomeMessage();
        Console.WriteLine($"What is todays date?");
        today = promptUserDate();
        while(true){
            userMenu();
        }
    }
    static void WelcomeMessage(){
        Console.WriteLine("Welcome to your journal");
    }
    static void promptSaveJournal(){
        Console.WriteLine($"What is the name of this journal?");
        Console.Write($">");
        string name = Console.ReadLine();
        Journal.saveJournal(name);
    }
    static void promptLoadJournal(){
         bool merge = false;
        Console.WriteLine($"What is the name of your journal?");
        Console.Write($">");
        string name = Console.ReadLine();
        if (Journal._entries.Count > 0){
            Console.WriteLine($"Would you like to save exiting entries into the existing journal?\n(loading a jounral without saving will erase your entries)");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write($">");
            switch(readInt()){
                case 1:
                    merge = true;
                    break;
                case 2:
                    merge = false;
                    break;
            }
        }
        Journal.loadJournal(name, merge);
    }
    static void userMenu(){
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
        switch (readInt()){
            case 1:
                promptSaveJournal();
                break;
            case 2:
                try{
                    promptLoadJournal();
                    Console.WriteLine($"Journal Loaded!");
                }
                catch(FileNotFoundException){
                    Console.WriteLine("!! I could not find your journal !!");
                }
                break;
            case 3:
                promptUserEntry();
                break;
            case 4://remove entry
                Console.WriteLine($"What date would you like to remove, leave blank for today? (M/D/Y):");
                string input = Console.ReadLine();
                if(input == "") Journal.remove(today);
                Journal.remove(input);
                break;
            case 5:
                Journal.display();
                break;
            case 6://get a prompt
                Journal.giveMePrompt();
                promptUserEntry();
                break;
            case 7:
                Console.WriteLine($"What date would you like to change to?");
                today = promptUserDate();
                break;
            case 8://quit
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
    static void promptUserEntry(){
        Console.WriteLine($"Make an entry for your journal:");
        Entry entry = new Entry(today, Console.ReadLine());
        Journal.add(entry);
        Journal.display();
    }
    static Date promptUserDate(){
        Console.Write($"Year: ");
        int year = readInt();
        Console.Write($"Month: ");
        int month = readInt();
        Console.Write($"Day: ");
        int day = readInt();
        return new Date(year, month, day);
    }
}