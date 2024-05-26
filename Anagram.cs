using System;

public class GFG
{
    public static void Main()
    {   
        String a = Console.ReadLine();
        String b = Console.ReadLine();
        
        char[] chra = a.ToCharArray();
        char[] chrb = b.ToCharArray();
        
        Array.Sort(chra); 
        String stra = new String(chra); 
        Array.Sort(chrb); 
        String strb = new String(chrb);
        
        Console.WriteLine(stra.Equals(strb));
        
    }
}
