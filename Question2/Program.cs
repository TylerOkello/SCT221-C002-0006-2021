using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = random.Next();

        int lastDigit = n % 10;
        Console.WriteLine("The last digit is: " + lastDigit);
    }
}