using System;

public class GFG
{

    public static void Main()
    {
    int left = Convert.ToInt32(Console.ReadLine());
    int right = Convert.ToInt32(Console.ReadLine());
    
    Random rand = new Random(); 
    int num = rand.Next(left, right+1);
    Console.WriteLine(num);
    }
}
