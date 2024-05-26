using System;

public class GFG
{
    public static void Main()
    {  
        int num = int.Parse(Console.ReadLine());
        string[] strings = new string[num];
        for(int i=0;i<num;i++) {
            strings[i] = Console.ReadLine();
        } 
        
        if(strings.Length==0) {
            Console.WriteLine(""); 
        } else {
            string prefix  = strings[0];
            for(int i=0;i<strings.Length;i++) {
                while(strings[i].IndexOf(prefix)!=0) 
                {
                    prefix = prefix.Substring(0,prefix.Length-1); 
                    if(string.IsNullOrEmpty(prefix)) {
                    break;
                    }
                }
            } 
            Console.WriteLine(prefix);
        }
    }
}
