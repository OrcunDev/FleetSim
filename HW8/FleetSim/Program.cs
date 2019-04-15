using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Class;
using FleetSim.Objects.Enum;

namespace FleetSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(); car1.Model = "Mercedes";car1.CarColor = Color.white;
            Car car2 = new Car(); car2.Model = "Volvo"; car2.CarColor = Color.red;
            Car car3 = new Car(); car3.Model = "Toyota"; car3.CarColor = Color.blue;
            Car car4 = new Car(); car4.Model = "BMW"; car4.CarColor = Color.white;
            Car car5 = new Car(); car5.Model = "Ferrari"; car5.CarColor = Color.red;

            Random rd = new Random();
            Console.WriteLine("Cars info " + car1.Model + " " + car1.CarColor + " " + car1.Vin);
            Console.WriteLine("Cars info " + car2.Model + " " + car2.CarColor + " " + car2.Vin);
            Console.WriteLine("Cars info " + car3.Model + " " + car3.CarColor + " " + car3.Vin);
            Console.WriteLine("Cars info " + car4.Model + " " + car4.CarColor + " " + car4.Vin);
            Console.WriteLine("Cars info " + car5.Model + " " + car5.CarColor + " " + car5.Vin);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("After 1 month...");

                car1.Mileage += rd.Next(5, 15000); car1.LastServicedDate = car1.LastServicedDate; car1.TuneUp(); car1.LastServicedDate= car1.LastServicedDate.AddMonths(1);
                Console.WriteLine($"car1 : Mileage is {car1.Mileage}, Last Dervice Date is {car1.LastServicedDate}");
                car2.Mileage += rd.Next(5, 15000); car2.LastServicedDate = car2.LastServicedDate;car2.TuneUp() ; car2.LastServicedDate = car2.LastServicedDate.AddMonths(1);
                Console.WriteLine($"car2 : Mileage is {car2.Mileage}, Last Dervice Date is {car2.LastServicedDate}");
                car3.Mileage += rd.Next(5, 15000); car3.LastServicedDate = car3.LastServicedDate;car3.TuneUp(); car3.LastServicedDate = car3.LastServicedDate.AddMonths(1);
                Console.WriteLine($"car3 : Mileage is {car3.Mileage}, Last Dervice Date is {car3.LastServicedDate}");
                car4.Mileage += rd.Next(5, 15000); car4.LastServicedDate = car4.LastServicedDate; car4.TuneUp(); car4.LastServicedDate = car4.LastServicedDate.AddMonths(1);
                Console.WriteLine($"car4 : Mileage is {car4.Mileage}, Last Dervice Date is {car4.LastServicedDate}");
                car5.Mileage += rd.Next(5, 15000); car5.LastServicedDate = car5.LastServicedDate; car5.TuneUp(); car5.LastServicedDate = car5.LastServicedDate.AddMonths(1);
                Console.WriteLine($"car5 : Mileage is {car5.Mileage}, Last Dervice Date is {car5.LastServicedDate}");

            }
            
            Console.ReadLine();
        }

    }
}
