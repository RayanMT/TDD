using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDFinal
{
    public static class MaintenanceHelper
    {
        public static int CountNeedsService(List<Vehicle> vehicles)
        {
            int count = 0;
            foreach (var v in vehicles)
            {
                if (v.MaintenanceStatus == "Needs Service")
                    count++;
            }
            return count;
        }
    }
}

