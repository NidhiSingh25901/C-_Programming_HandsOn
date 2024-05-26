using System;

public class GFG {
    static void decToBinary(int n)
    {
        int[] binaryNum = new int[32];
        int i = 0;
        while (n > 0) {
            binaryNum[i] = n % 2;
            n = n / 2;
            i++;
        }
        for (int j = i - 1; j >= 0; j--)
            Console.Write(binaryNum[j]);
    }

    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        decToBinary(n);
    }
}
