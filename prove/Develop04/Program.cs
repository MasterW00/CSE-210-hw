using System;

class Program
{
    private static Breathe breathe = new Breathe(10);
    private static Reflect reflect = new Reflect(15);
    private static Listen listen = new Listen();
    static void Main(string[] args)
    {
        menu();
    }
    static void menu(){
        bool exit = false;
        do{
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Breathe");
            Console.WriteLine("2. Reflect");
            Console.WriteLine("3. Listen");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Enter a number: ");
            int inp = int.Parse(Console.ReadLine());
            switch(inp){
                case 1:
                    breathe.Start();
                    break;
                case 2:
                    reflect.Start();
                    break;
                case 3:
                    listen.Start();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        while(!exit);
    }
}