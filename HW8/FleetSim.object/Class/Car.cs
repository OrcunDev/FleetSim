using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;

namespace FleetSim.Objects.Class
{
    public class Car : Vehicle
{
       public int Year { get; set;}
       public string Make { get; set;}
       public string Model { get; set;}
       
        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        public Car(int year2, string make2, string model2, Color carColor2)
        {
            Year = year2;
            Make = make2;
            Model = model2;
            CarColor = carColor2;
        }
        public Car()
        {
            Vin = Guid.NewGuid().ToString();
            Mileage = 0;
            LastServicedMileage = 0;

        }
}

}
