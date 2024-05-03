using System;

class Program
{
    static void ListSort(List<int> list){
        
    }
    static void Main(string[] args) 
    {
        Console.WriteLine($"Enter a series of numbers");
        List<int> numbers = new List<int>();

        while(true){
            Console.Write($">");
            int enter = int.Parse(Console.ReadLine());
            if (enter == 0){
                break;
            }
            numbers.Add(enter);
        }
        int sum_total = 0;
        int p_0 = numbers[1];

        foreach(int number in numbers){
            if (number > 0 && number < p_0){
                p_0 = number;
            }
            sum_total += number;
        }
        ListSort(numbers);
        Console.WriteLine($"The sum total of the list is {sum_total}");
        Console.WriteLine($"The average of all the numbers is {sum_total/numbers.Count}");
        Console.WriteLine($"{p_0} is the positive number closest to zero from the list");
        
    }
}