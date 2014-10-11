using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle
    {
        public string VehicleName {private get; set; }
        public string RegNo {private get; set; }
        public double Speed { private get; set; }
        public double Maximum { get; private set; }
        public double Minimum { get; private set; }
        public double Average { get; set; }
        private int count =1;

        public Vehicle(string vehicleName,string regNo):this()
        {
            VehicleName = vehicleName;
            RegNo = regNo;
        }

        public Vehicle()
        {
            Speed = 0;
            Maximum = 0;
            Minimum = 0;
        }

        public void GetSpeed(double currentSpeed)
        {
            count++;
            if (currentSpeed > Maximum)
            {
                Maximum = currentSpeed;
            }
            if (currentSpeed < Minimum || Speed ==0 )
            {
                Minimum = currentSpeed;
            }
            Speed = currentSpeed;

        }

        public void GetAverage()
        {
            Average = Speed/count;
        }

    }
}
