using System;

class Program
{
    static void Main(string[] args)
    {
        while (true){
            Console.Clear();
            Display();
            Console.ReadLine();
            Console.Clear();
            Menu();
            
        }
    }
    static void Menu(){
        bool exit = false;
        do{
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add skill");
            Console.WriteLine("2. Open Skill");
            Console.WriteLine("3. List All");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Enter a number: ");
            int inp = int.Parse(Console.ReadLine());
            Console.WriteLine($"");
            switch(inp){
                case 1:
                    Console.Write("Enter Skill Name: ");
                    new Skill(Console.ReadLine()).CreateEnemy();

                    break;
                case 2:
                    try
                    {
                        Console.WriteLine($"Enter the list number");
                        SkillMenu(Skill._skills[int.Parse(Console.ReadLine()) - 1]);
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        Console.WriteLine($"Not in list");
                    }
                    
                    break;
                case 3:
                    foreach(Skill skill in Skill._skills){
                        skill.Display();
                        
                    }
                    break;
                case 4:
                    foreach(Skill skill in Skill._skills){
                        skill._enemy.Acheivment();
                    }
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        while(!exit);
    }
    static void SkillMenu(Skill skill){
        bool exit = false;
        do{
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Add Objective");
            Console.WriteLine("3. List Objectives");
            Console.WriteLine("4. Complete Objective");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Enter a number: ");
            int inp = 0;
            try {inp = int.Parse(Console.ReadLine());}
            catch(System.FormatException){};
            switch(inp){
                case 1:
                    Console.WriteLine($"Enter a task");
                    skill.Add_Objective(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine($"Enter your Objective");
                    string name = Console.ReadLine();
                    Console.WriteLine($"How many times till you complete this Goal?");
                    skill.Add_Objective(name, int.Parse(Console.ReadLine()));
                    break;
                case 3:
                    skill.Display();
                    break;
                case 4:
                    skill.Acheivment();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        while(!exit);
    }
    static void Display(){
        Console.WriteLine("     Welcome to Skill-Mah-Grah!");
        Console.WriteLine($"         _Press_Enter_");
        Console.WriteLine($"--------------------------------");
        Console.WriteLine($"Storage:              Warning!");
        Console.WriteLine($"  OFF            Everytime you exit");
        Console.WriteLine($"   ^               your enemys get");
        Console.WriteLine($"  ON                  STRONGER");
    }
    
}