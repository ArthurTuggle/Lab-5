using System;  
  public class Speed  
   {  
     public static void Main(string[] args)  
      { 
           int i;
           double distance=0,time=0,speed=0,average=0 ,total=0;    
           for(i = 1; i <= 7; i++)    
          {
             Console.Write("\nEnter the distance covered by car #"+i);    
             distance = double.Parse(Console.ReadLine()); 
             Console.Write("\nEnter the time taken by car #"+i);    
             time = double.Parse(Console.ReadLine()); 
             speed=  distance/time; 
             total+=speed;
             Console.Write("\nThe speed of this car is "+ speed +" mph");    
          }
          average =total/7;
          Console.Write("\nThe average  speed of the cars is "+ average +"mph");    
     }  
   }