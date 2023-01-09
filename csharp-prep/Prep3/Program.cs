using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magNum = Console.ReadLine();
        int x = int.Parse(magNum);
        int y = 0;

        while (y != x) {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            y = int.Parse(guess);
            
            if (y < x) {
                Console.WriteLine("Higher");
            }
            else if (y > x) {
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessesd it!");
            }
        }
        


    }
}