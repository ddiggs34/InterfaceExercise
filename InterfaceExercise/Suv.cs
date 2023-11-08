using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv: IVehicle, ICompany
    {
        public int CargoSpace { get; set; }
        public bool ThirdRowSeating { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public string Logo { get; set; }
        public string Motto { get; set; }
    }
}
