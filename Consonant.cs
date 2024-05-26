using System;

public class GFG
{

    public static void Main()
    {  
       string str = Console.ReadLine();
       char[] ch = str.ToCharArray(); 
       int c=0;
       for(int i=0;i<ch.Length;i++) { 
           char chr = ch[i];
           if(chr!='a' && chr != 'e' && chr != 'i' && chr !='o' && chr!='u'&& chr!='A' && chr!='E' && chr!='I' && chr!='O' && chr!='U') {
               c+=1;
           }
       } 
       Console.WriteLine(c);
    }
}
