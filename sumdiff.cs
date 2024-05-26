using System;

public class Reverse {
    public static void Main(String[] args) {
        int firstnum; 
        firstnum = Convert.ToInt32(Console.ReadLine()); 
        int secondnum; 
        secondnum = Convert.ToInt32(Console.ReadLine()); 
        int sum = firstnum +secondnum; 
        int diff =0;
        if(firstnum > secondnum) {
            diff = firstnum - secondnum;
        } else if (firstnum < secondnum) {
            diff = secondnum - firstnum;
        } else {
            diff =0;
        } 
        Console.WriteLine(sum);
        Console.WriteLine(diff);
    }
}