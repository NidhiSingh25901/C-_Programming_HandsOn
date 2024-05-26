using System;

public class GFG
{

    public static void Main()
    {  
        Console.WriteLine("Enter Sentence");
     string str = Console.ReadLine();
     string[] ch = str.Split(new char[]{' ',',','.','?','!'}, StringSplitOptions.RemoveEmptyEntries);
     int maxLength = 0;
     string Longestword = "";
     foreach(string word in ch) {
         if(word.Length > maxLength) {
             maxLength = word.Length;
             Longestword = word;
         }
     } 
     Console.WriteLine(Longestword);
    }
}
