using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDFinal
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string MaintenanceStatus { get; set; }

        public Vehicle(string vehicleNumber, string model, string manufacturer, int year, string type, string maintenanceStatus)
        {
            VehicleNumber = vehicleNumber;
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            Type = type;
            MaintenanceStatus = maintenanceStatus;
        }
    }
}
