using Brobeans1.Objects;
using System;

namespace Brobeans1
{
	/// <summary>
	/// NOTES:
	/// OOP / classes / instances
	/// Namespaces
	/// Exceptions
	/// String format sugar
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			#region Read/write console
			//Console.WriteLine("What is your name? ");

			//var name = Console.ReadLine();
			//Console.WriteLine($"Hello {name}!");
			#endregion

			#region Environment variables
			Console.WriteLine(Environment.GetEnvironmentVariable("MY_VAR"));
			#endregion

			#region OOP
			var myCar = new Sedan(2, 5);
			Console.WriteLine(myCar.Wheels); // 0 when Wheels is not set

			var myTruck = new Pickup(6, false);
			if (myTruck.TruckNuts)
			{
				Console.WriteLine("My Truck Has Nuts: yes");
			}
			else
			{
				Console.WriteLine("My Truck Has Nuts: no");
			}
			#endregion
		}
	}
}
