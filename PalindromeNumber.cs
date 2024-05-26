using System;

public class GFG
{

    public static void Main()
    {
   int num = Convert.ToInt32(Console.ReadLine()); 
   int reversernumber = 0;
   int temp =num;
   while(temp!=0) {
       reversernumber = reversernumber * 10 + (temp%10); 
       temp = temp/10;
   } 
   if(reversernumber == num ) {
       Console.WriteLine("Palindrome"); 
   } else {
       Console.WriteLine("Not Palindrom Number");
   }
    }
}
