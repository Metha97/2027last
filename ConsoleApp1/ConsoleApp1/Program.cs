using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("Enter a Number : ");
        string input = Console.ReadLine();
        int number;
        if(int.TryParse(input, out number))
        {
            Console.WriteLine("integer");
        }
        else
        {
            Console.WriteLine("not integer");
        }
        Console.ReadLine();
    }
}