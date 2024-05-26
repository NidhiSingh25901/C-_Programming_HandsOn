using System;

public class GFG {

    public static void Main()
    {
     int num; 
     int c=0;
     num = Convert.ToInt32(Console.ReadLine());
     for(int i=2;i<num;i++) {
         if(num%i==0) {
             c+=1;
             break;
         }
     } 
     if(c==0) {
         Console.WriteLine("Prime Number");
     } else {
         Console.WriteLine("Not Prime Number");
     }
    }
}
