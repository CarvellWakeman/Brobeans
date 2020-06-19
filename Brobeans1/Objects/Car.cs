namespace Brobeans1.Objects
{
	public interface IEngine {

		bool Start();

		void Stop();
	}

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

		public virtual int Move(bool forward)
		{
			return forward ? 1 : -1;
		}
	}

	public class Sedan : Car, IEngine
	{
		public int Doors { get; private set; }

		public Sedan(int doors, int wheels) : base(wheels)
		{
			Doors = doors;
		}

		public bool Start()
		{
			Doors -= 1;

			return true;
		}

		public void Stop()
		{
			throw new System.NotImplementedException();
		}

		public void LowerSunroof()
		{

		}
	}

	public class Pickup : Car
	{
		public TruckNuts TruckNuts { get; }

		public Pickup(int wheels, TruckNuts truckNuts = null) : base(wheels)
		{
			TruckNuts = truckNuts;
		}


		public override int Move(bool forward)
		{
			TruckNuts.Wiggle();
			return base.Move(forward);
		}
	}
}
