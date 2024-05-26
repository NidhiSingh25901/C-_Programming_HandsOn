using System;
using System.Linq; 
public class GFG
{
    public static void Main()
    {   
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string[] distinctWords = words.Distinct().ToArray();
        string output = string.Join(" ", distinctWords);
        Console.WriteLine(output);
    }
}
