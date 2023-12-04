using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = random.Next(-100, 101);

        if (n > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (n < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}