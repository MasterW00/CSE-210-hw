class UserIn
{
    UserIn(){

    }
    static float InputFloat(){ 
        while(true){
            Console.Write($"Number >");
            string input = Console.ReadLine();
            if(float.TryParse(input, out float put)){
                return put;
            }
        }
    }
    static int InputInt(){ 
        while(true){
            Console.Write($"Number >");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int put)){
                return put;
            }
        }
    }
    static bool InputBool(){
        while(true){
            Console.Write($"YES or NO>");
            string input = Console.ReadLine();
            if(input.ToLower().Contains('y')){
                return true;
            }
            else if (input.ToLower().Contains('n')){
                return false;
            }
        }
    }
    //Polymorph :)
    public static void Prompt(string message, out bool output){
        Console.Clear();
        Console.WriteLine($"{message}");
        output = InputBool();
    }
    public static void Prompt(string message, out float output){
        Console.Clear();
        Console.WriteLine($"{message}");
        output = InputFloat();
    }
    public static void Prompt(string message, out int output){
        Console.Clear();
        Console.WriteLine($"{message}");
        output = InputInt();
    }
}