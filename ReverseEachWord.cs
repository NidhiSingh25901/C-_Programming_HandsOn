using System;
using System.Linq;
public class GFG
{
    public static void Main()
    {   
        string str = Console.ReadLine();
        string[] word = str.Split(new char[]{' ','.',',','?','!'}, StringSplitOptions.RemoveEmptyEntries); 
       
        string reversesentence=" ";
        foreach(string words in word) {
            char[] ch = words.ToCharArray(); 
           Array.Reverse(ch);
            string newword = new String(ch);
            reversesentence+=newword+" ";
        } 
        Console.WriteLine(reversesentence);
    }
}
