using System;
					
public class Program
{
	public static void Main()
	{
		//var myVal = Convert.ToInt32(Console.ReadLine());
		// Console.WriteLine(myVal);
		
		var myVal = Console.ReadLine();
		var toRemove = "/";
		var result = String.Empty;
		
		int i = myVal.IndexOf(toRemove);
		
		
		if (i >= 0)
		{
			result= myVal.Remove(i, toRemove.Length);
		}
		Console.WriteLine("Source: {0}", myVal );
		Console.WriteLine("Result: {0}", result);
		
		
		
	}
}
