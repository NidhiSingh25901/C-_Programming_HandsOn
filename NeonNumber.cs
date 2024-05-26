using System;

public class GFG
{

    public static void Main()
    {  
        int num = Convert.ToInt32(Console.ReadLine()); 
        int doublenumber = num * num;
        int sum =0;
        int temp = doublenumber;
        while(temp!=0) {
            sum= sum+(temp%10); 
            temp/=10;
        } 
        if(sum==num) {
            Console.WriteLine("Neon Number");
        } else {
            Console.WriteLine("Not a Neon Number");
        }
    }
}
