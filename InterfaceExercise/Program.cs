using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        

        static void Main(string[] args)

        {

            var truck = new Truck()
            {
                Name = "Ford F-150",
                Brand = "BrandX",
                Wheels = 4,
                HeadLights = 2,
                Doors = 2,
                WindShieldWipers = true,
                TruckBed = "yes",
                Large = "yes"

            };
            var car = new Car()
            {
                Name = "Toyota",
                Brand = "Best brand",
                Wheels = 4,
                HeadLights = 2,
                Doors = 4,
                WindShieldWipers = true,
                HasTrunk = true,
                TailLights = 2
            };
            var suv = new SUV()
            {
                Name = "RAV4",
                Brand = "Toyota",
                Wheels = 4,
                HeadLights = 2,
                Doors = 4,
                WindShieldWipers = true,
                SunRoof = true,
                CargoHold = true


            };

            var vehicles = new List<IVehicle>() { car, truck, suv };

            vehicles.Add(truck);
            vehicles.Add(car);
            vehicles.Add(suv);


            

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"My {vehicle.Name} {vehicle.Brand}  has {vehicle.Wheels} wheels and {vehicle.HeadLights} headlights. It has {vehicle.Doors}  doors and it's {vehicle.WindShieldWipers} to have windshield wipers!  ");




              

            }

            

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
