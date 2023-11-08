using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public bool CoupeOption { get; set; }
        public int TrunkSpace { get; set; }
        public int NumberOfWheels { get ; set ; }
        public string Make { get; set ; }
        public string Model { get; set ; }
        public int NumberOfSeats { get ; set; }
        public string Logo { get ; set ; }
        public string Motto { get ; set ; }
    }
}
