using System;  
public class Program  
{  
    public static void Main()  
{  
    string[] arr = new string[5]; 

    Console.Write("\n\nRead and Print elements of an array:\n");
    Console.Write("-----------------------------------------\n");	
  
    Console.Write("Input 5 elements in the array :\n");

    int i;

    for(i=0; i<5; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    arr[i] = Console.ReadLine();  		
    }  
  
    Console.Write("[ " + string.Join(", ", arr.Where(c => c.Length <= 3).ToArray()) + " ]");
  }
}