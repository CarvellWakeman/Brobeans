namespace Brobeans1.Objects
{
	/// <summary>
	/// Base of something else, can't have one alone
	/// </summary>
	public abstract class Car
	{
		public int Wheels;

		public Car(int wheels)
		{
			Wheels = wheels;
		}
	}

	public class Sedan : Car
	{
		public int Doors { get; }

		public Sedan(int doors, int wheels) : base(wheels)
		{
			Doors = doors;
		}
	}

	public class Pickup : Car
	{
		public bool TruckNuts { get; }

		public Pickup(int wheels, bool truckNuts = true) : base(wheels)
		{
			TruckNuts = truckNuts;
		}
	}
}
