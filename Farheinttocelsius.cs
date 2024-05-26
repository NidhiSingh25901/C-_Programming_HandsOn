using System;

public class Reverse {
    public static void Main(String[] args) {
    float num;
    num = Convert.ToSingle(Console.ReadLine());
    if(num%5==0)  {
        Console.WriteLine("Divisible by 5");
    } else {
        Console.WriteLine("Not Divisible by 5");
    }
    }
}