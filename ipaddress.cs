using System;
using System.Linq;
public class GFG
{
    public static void Main()
    {   
        string str = "1.1.1";
        int length = str.Length; 
        string word="";
        char[] ch = str.ToCharArray();
        for(int i=0;i<length;i++) { 
            if(ch[i].Equals('.')) 
            word=word+"[.]"; 
            else 
            word=word+ch[i];
        }  
        Console.WriteLine(word);
    }
}
