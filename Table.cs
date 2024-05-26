using System;

public class Reverse {
    public static void Main(String[] args) { 
        int num;
        num = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=10;i++) {
            Console.WriteLine( num + " x " + i + " = " + (num*i));
        }
    }
}