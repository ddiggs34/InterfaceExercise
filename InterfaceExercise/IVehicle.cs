﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */

        public int NumberOfWheels { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
    }

}
