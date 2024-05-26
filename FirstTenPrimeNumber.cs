using System;

public class GFG
{
    public static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false; // 1 and numbers less than 1 are not prime
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false; // If num is divisible by any number less than or equal to its square root, it's not prime
            }
        }

        return true; // If no divisors are found, num is prime
    }

    public static void Main()
    {
        int count = 0;
        int num = 2;

        while (count < 10)
        {
            if (IsPrime(num))
            {
                Console.WriteLine(num);
                count++;
            }
            num++;
        }
    }
}
