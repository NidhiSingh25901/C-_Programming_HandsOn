using System;

public class GFG
{

    public static void Main()
    {  
       string str = Console.ReadLine();
       char[] ch = str.ToCharArray(); 
       string[] word= str.Split(' ');
       Console.WriteLine(ch.Length); 
       Console.WriteLine(word.Length);
    }
}
