using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool DieselGasOption { get; set; }
        public int TruckBedSpace {  get; set; }
        public int NumberOfWheels { get ; set; }
        public string Make { get ; set; }
        public string Model { get ; set; }
        public int NumberOfSeats { get ; set ; }
        public string Logo { get ; set; }
        public string Motto { get ; set ; }
    }
}
