using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
  
    public static void Main()
	{

		Console.WriteLine("How many records do you want to add?");
		var numberOfRecords = int.Parse(Console.ReadLine());

		var recordList = new List<ChocolateBar>();
		
		for (int i = 0; i < numberOfRecords; i++)
		{
			// In this loop, populate the object's properties using Console.ReadLine()
			var chocolateBar = new ChocolateBar();

			Console.WriteLine("How many calories does the chocolate bar have?");
			chocolateBar.Calories = int.Parse(Console.ReadLine());
			Console.WriteLine("How many grams of fat does the chocolate bar have?");
			chocolateBar.FatGrams = decimal.Parse(Console.ReadLine());


			recordList.Add(chocolateBar);
			
		}
		foreach (var chocolateBar in recordList) 
		{
            Console.WriteLine(chocolateBar.ToString());
        }
        
    }
}

// Print out the list of records using Console.WriteLine()
