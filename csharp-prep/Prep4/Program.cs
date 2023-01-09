using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when Finished.");
        
        List<int> digits = new List<int>();
        int num = -1;
        while (num != 0) {
            Console.Write("Enter number: ");
            string digy = Console.ReadLine();
            num = int.Parse(digy);
            digits.Add(num);

        }
        int sum = 0;
        foreach (int digit in digits){
            sum += digit;            
        }
        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / digits.Count;
        Console.WriteLine($"The Average is : {avg}");

        int max = digits[0];

        foreach (int digit in digits) {
            if (digit > max) {
                max = digit;
            }
        }
        Console.WriteLine($"The max is : {max}");



    }
}