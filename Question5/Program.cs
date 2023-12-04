using System;

class Program
{
    static void PrintReversedString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }

    static void Main()
    {
        string originalString = "Hello, world!";
        PrintReversedString(originalString);
    }
}