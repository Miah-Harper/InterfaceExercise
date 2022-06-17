using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public int TailLights { get; set; }


        public int Wheels { get; set; } = 4;
        public int HeadLights { get; set; } = 2;
        public int Doors { get; set; } = 4;
        public bool WindShieldWipers { get; set; } = true;

        public string Name { get; set; }

        public bool Logo { get; set; } = true;
        public string Brand { get; set; } = "Ford";
        string ICompany.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is driving forward");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is parked");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} driving reverse");
        }
    }

	
		//public Car()
		//{
		//}

		
	
}

