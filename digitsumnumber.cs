using System;

public class Reverse {
    public static void Main(String[] args) {
    
    int sum =0;
    int temp = Convert.ToInt32(Console.ReadLine());
    while(temp!=0)  {
        sum =sum +(temp%10);
        temp=temp/10;
    } 
    Console.WriteLine(sum);
    }
}