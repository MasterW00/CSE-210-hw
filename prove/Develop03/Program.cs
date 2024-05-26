using System;
class Program
{
    static void Main(string[] args)
    {
        Scripture first = new Scripture("BookOfMormon", "2 Nephi", 1, 2, 5);
        Standard_Works.findVerse(first);
        while(true){
            first.printScripture();
        if (first.hideWords()) Environment.Exit(0);
            if (Console.ReadLine().Contains('q')) break;
        }
    }
}

// public class Book{
//     public string title;
// }
