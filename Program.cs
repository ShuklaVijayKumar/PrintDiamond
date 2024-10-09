using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        char inputChar = char.ToUpper(Console.ReadLine()[0]);
        PrintDiamond(inputChar);
    }

    public static void PrintDiamond(char targetChar)
    {
        int size = targetChar - 'A';

        // Build the diamond lines
        for (int i = 0; i <= size; i++)
        {
            Console.WriteLine(GenerateLine(i, size));
        }

        for (int i = size - 1; i >= 0; i--)
        {
            Console.WriteLine(GenerateLine(i, size));
        }
    }

    private static string GenerateLine(int lineIndex, int totalSize)
    {
        char letter = (char)('A' + lineIndex);
        int outerSpaces = totalSize - lineIndex;
        int innerSpaces = lineIndex > 0 ? 2 * lineIndex - 1 : 0;

        // Create the line using underscores to visualize spaces
        string line = new string('_', outerSpaces) + letter;
        if (innerSpaces > 0)
        {
            line += new string('_', innerSpaces) + letter;
        }

        return line.PadRight(2 * totalSize + 1, '_');
    }
}
