using System;

public class GFG
{
    public static void Main()
    {  
      Console.WriteLine("Enter Sentence");
      string str = Console.ReadLine(); 
      str=str+" ";
      string reversesentence ="";
      string[] word = str.Split(new char[]{' ',',','.','?','!'}, StringSplitOptions.RemoveEmptyEntries);
         Array.Reverse(word); 
         reversesentence = string.Join(" ",word);
      Console.WriteLine(reversesentence);
    }
}
