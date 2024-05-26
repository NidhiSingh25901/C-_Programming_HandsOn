using System;

public class Reverse {
    public static void Main(String[] args) {
        int num; 
        num = Convert.ToInt32(Console.ReadLine()); 
        if(num%2==0) {
            Console.WriteLine("Even Number");
        } else {
            Console.WriteLine("Odd Number");
        }
    }
}