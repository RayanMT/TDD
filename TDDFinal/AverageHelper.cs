using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDDFinal;


namespace TDDFinal
{
    public static class AverageHelper
    {
        public static double CalculateAverageYear(List<Vehicle> vehicles)
        {
            if (vehicles == null || vehicles.Count == 0)
                return 0;

            int sum = 0;
            foreach (var v in vehicles)
            {
                sum += v.Year;
            }
            return (double)sum / vehicles.Count;
        }
    }
}
 




