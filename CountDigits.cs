using System;

public class Reverse {
    public static void Main(String[] args) {
        int num; 
        num = Convert.ToInt32(Console.ReadLine()); 
        int count =0; 
        while(num!=0) {
            count = count+1; 
            num= num/10;
        } 
       Console.WriteLine(count);
    }
}