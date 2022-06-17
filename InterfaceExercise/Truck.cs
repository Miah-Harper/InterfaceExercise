using System;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public string TruckBed { get; set; }
        public string Large { get; set; }

        public int Wheels { get; set; } = 4;
        public int HeadLights { get; set; } = 2;
        public int  Doors { get; set; } = 4;
        public bool WindShieldWipers { get; set; } = true;

        public string Name { get; set; }

        public bool Logo { get; set; } = true;
        public string  Brand { get; set; } = "Kia";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is barely driving forward");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is now parked");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} is driving reverse");
        }
    }

}


