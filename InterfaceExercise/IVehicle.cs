using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int Wheels { get; set; }
		public int HeadLights{ get; set; }
		public int  Doors { get; set; }
		public bool WindShieldWipers { get; set; }

		public string Name { get; set; }
		public string Brand { get; set; }

		
	}
}

