class UserIn
{
    UserIn(){

    }
    static float InputFloat(){ 
        while(true){
            Console.Write($"Number >");
            string input = Console.ReadLine();
            (float put, bool bun) = ParseFloat(input);
            if(bun){
                return put;
            }
        }
    }
    static int InputInt(){ 
        while(true){
            Console.Write($"Number >");
            string input = Console.ReadLine();
            (int put, bool bun) = ParseInt(input);
            if(bun){
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
    public static void Prompt(string message, out bool output, bool clear = false){
        if (clear) Console.Clear();
        Console.WriteLine($"{message}");
        output = InputBool();
    }
    public static void Prompt(string message, out float output, bool clear = false){
        if (clear) Console.Clear();
        Console.WriteLine($"{message}");
        output = InputFloat();
    }
    public static void Prompt(string message, out int output, bool clear = false){
        if (clear) Console.Clear();
        Console.WriteLine($"{message}");
        output = InputInt();
    }
    public static void Prompt(string message, out string output, bool clear = false){
        if (clear) Console.Clear();
        Console.WriteLine($"{message}");
        output = Console.ReadLine();
    }
    public static void  PopulateList<T>(string message, List<T> list, Func<string,(T, bool)> parsefunc, bool clear = false){
        if(clear){
            Console.Clear();
        }
        string input;
                do{
                    UserIn.Prompt($"{message}", out input);
                    (T put, bool bun) = parsefunc(input);
                    if(bun){
                        list.Add(put);
                    }
                }
                while(input != "");
    }
    public static (int, bool) ParseInt(string input){
        if(int.TryParse(input, out int put)){
                return (put, true);
            }
        else return (0, false);
    }
    public static (float, bool) ParseFloat(string input){
        if(int.TryParse(input, out int put)){
                return (put, true);
            }
        else if(input == ""){
            return (0, true);
        }
        else return (0, false);
    }

}