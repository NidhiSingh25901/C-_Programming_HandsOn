using System;

public class GFG
{

    public static void Main()
    {  
       string str = Console.ReadLine();
       char[] ch = str.ToCharArray(); 
       Array.Reverse(ch);
       Console.WriteLine(ch);
    }
}
