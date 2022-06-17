using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}

		public bool SunRoof { get; set; }
		public bool CargoHold { get; set; }

        public int Wheels { get; set; } = 4;
        public int HeadLights { get; set; } = 2;
        public int Doors { get; set; } = 4;
        public bool WindShieldWipers { get; set; } = true;
        public string Name { get; set; } 

        public bool Logo { get; set; } = true;
        public string Brand { get; set; } = "Nissan";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is driving forward to park");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is parked in spot A6");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} is driving reverse towards the pond!");
        }
    }

}


