using System;

class Program
{
    static int GetPrefixLength(string input, string prefix)
    {
        int prefixLength = 0;

        while (prefixLength < input.Length && prefixLength < prefix.Length && input[prefixLength] == prefix[prefixLength])
        {
            prefixLength++;
        }

        return prefixLength;
    }

    static void Main()
    {
        string originalString = "abcdef";
        string prefix = "abc";

        int length = GetPrefixLength(originalString, prefix);
        Console.WriteLine($"Length of the prefix: {length}");
    }
}