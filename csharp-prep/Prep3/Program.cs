using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Write($"Pick a magic number\n>");
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine($"Hand the computer to your friend now!\nGuess the number!");
        int attempt = 0;
        while(true){
            Console.Write($">");
            int guess = int.Parse(Console.ReadLine());
            if (guess == target) break;
            if(guess > target){
                Console.WriteLine($"Your guess is too high...");
            }        
            if(guess < target){
                Console.WriteLine($"Your guess is too low...");
            }
            attempt++;
        }
        Console.Write($"You're right the number is {target}!\n");
        Console.WriteLine($"It took you {attempt} tries.");
        
    }
}