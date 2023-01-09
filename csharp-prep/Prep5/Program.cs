using System;

class Program
{
    static void DisplayWelcome() {
       Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromtUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int digit = int.Parse(Console.ReadLine());
        return digit;
    }

    static int SquareNumber(int digit) {
        int square = digit * digit;
        return square;
    }

    static void DisplayResult(string name, int square) {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(),PromtUserNumber());
    }
}