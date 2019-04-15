using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Interface;

namespace FleetSim.Objects.Class
{
  public class Vehicle : Interface1
    {
        private string vin;
        private int mileage;
        private Color carColor;
        private DateTime lastServicedDate;
        private int lastServicedMileage;
        public Vehicle()
        {
            lastServicedDate = DateTime.Today;
        }
       
        public string Vin
        {
            get
            {
                return this.vin;
            }
            set
            {
                this.vin = value;
            }
        }
         public int Mileage
              {
            get
            {
                return this.mileage;
            }
                 set
            {
                this.mileage = value;
            }
}
    public Color CarColor
        {
            get
            {
                return this.carColor;
            }
            set
            {
                this.carColor = value;
            }
        }

        public DateTime LastServicedDate
        {
            get
            {
                return this.lastServicedDate;
            }
            set
            {
                this.lastServicedDate = value;
            }
        }

        public int LastServicedMileage

        {
            get
            {
                return this.lastServicedMileage;
            }
            set
            {
                this.lastServicedMileage = value;
            }
        }


        public void TuneUp()
        {
            if(Mileage - LastServicedMileage >= 30000)
             {
                LastServicedMileage = Mileage;
                LastServicedDate = lastServicedDate.AddMonths(1);
                Console.WriteLine("Vehicle tuned up at" + LastServicedMileage + "on "+ LastServicedDate);
              }
            if (Mileage >= 100000)
            {
                RebuildEngine();

            }

        }
         public void RebuildEngine()
        {
            Mileage = 0;
            LastServicedMileage = 0;
            Console.WriteLine($"Engine rebuilt on + {LastServicedDate}  ");  /* + for + {this..Model} */

        }



    }
      
}
