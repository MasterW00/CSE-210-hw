using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction x = new Fraction(6, 2);
        Fraction a = new Fraction();
        Fraction y = new Fraction(4);
        a.setBottom(7);
        Console.WriteLine($"{a.bottom()}");
        a.setTop(8);
        Console.WriteLine($"{a.top()}");
        Console.WriteLine($"{x}, {x.GetDecimalValue()}, {y}, {y.GetDecimalValue()}, {a}, {a.GetDecimalValue()}");
    }
}