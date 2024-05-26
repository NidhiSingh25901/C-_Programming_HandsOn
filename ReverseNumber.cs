using System;

public class Reverse {
    public static void Main(String[] args) {
        int num; 
        num = Convert.ToInt32(Console.ReadLine()); 
        int k = num; 
        int reversenumber =0;
        while(k!=0){
            int digit = k%10;
            reversenumber = reversenumber*10 + digit;
            k=k/10;
        } 
        Console.WriteLine(reversenumber);
    }
}