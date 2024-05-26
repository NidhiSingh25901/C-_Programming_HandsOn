using System;

public class GFG
{

    public static void Main()
    {  
        int num = Convert.ToInt32(Console.ReadLine());
        int sqrtpow = (int)(Math.Sqrt(num));
        if((sqrtpow*sqrtpow) ==  num) {
            Console.WriteLine("Perfect Number");
        } else {
            Console.WriteLine("Not Perfect Number");
        }
    }
}
