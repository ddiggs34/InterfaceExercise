using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle - done
            
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


            var car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Mustang";
            car1.NumberOfWheels = 4;
            car1.NumberOfSeats = 2;
            car1.Logo = "Horse";
            car1.CoupeOption = false;

            var suv1 = new Suv();
            suv1.Make = "Jeep";
            suv1.Model = "Wrangler";
            suv1.NumberOfWheels = 4;
            suv1.NumberOfSeats = 4;
            suv1.Logo = "Jeep logo";
            suv1.ThirdRowSeating = false;

            var truck1 = new Truck();
            truck1.Make = "Ford";
            truck1.Model = "F-150 - Raptor";
            truck1.NumberOfWheels = 4;
            truck1.NumberOfSeats = 4;
            truck1.Logo = "Dinosaur";
            truck1.DieselGasOption = true;

            var carList = new List<IVehicle>() { car1, suv1, truck1 };

            foreach (var vehicle in carList)
            {
                if (vehicle is Car)
                {
                    Console.WriteLine($"This car is a {vehicle.Make} {vehicle.Model}");
                                    }

                else if (vehicle is Suv)
                {
                    Console.WriteLine($"This SUV is a {vehicle.Make} {vehicle.Model}");
                }

                else
                { 
                    Console.WriteLine($"This truck is a {vehicle.Make} {vehicle.Model}");
                }
            }
            


           
                

        }
    }
}
