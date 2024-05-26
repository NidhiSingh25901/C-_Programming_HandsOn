using System;
using System.Linq;
public class GFG
{
    public static void Main()
    {   
      int[] a=new int[10];
      for(int i=0;i<10;i++) {
          a[i]=Convert.ToInt32(Console.ReadLine());
      }  
      
     int[] m = a.Distinct().ToArray();
     for(int j=0;j<m.Length;j++)
      Console.Write(m[j]);
    }
}
