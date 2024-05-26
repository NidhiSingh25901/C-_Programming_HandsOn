using System;

public class GFG
{

    public static void Main()
    { 
     var num = Console.ReadLine();
     int length = num.Length;
     int number = Convert.ToInt32(num); 
     int temp = number; 
     int digit =0;
     double mulnumber =0;
     double sum=0;
     while(temp!=0) {
         digit = temp%10;
         mulnumber = Math.Pow(digit,length);
         sum = sum+mulnumber;
         temp=temp/10;
     } 
     if(sum == number) {
         Console.WriteLine("YES");
     } else {
         Console.WriteLine("No");
     }
    }
}
