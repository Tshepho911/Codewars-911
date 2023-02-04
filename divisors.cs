using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static int[] Divisors(int n)
  {

   List<int> list = new List<int>();
   for(int i=2; i<n; i++){
     if(n%i==0){
       if(i==n)
         break;
       else
       list.Add(i);
     }
   }
    if(list.Count() == 0)
      return null;
    return list.ToArray();
    
}
}