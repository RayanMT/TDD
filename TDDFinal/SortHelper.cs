using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDFinal;

namespace TDDFinal
{
    public static class SortHelper
    {
        public static List<Vehicle> BubbleSort(List<Vehicle> list)
        {
            var sortedList = new List<Vehicle>(list);
            int n = sortedList.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedList[j].Year < sortedList[j + 1].Year)
                    {
                        var temp = sortedList[j];
                        sortedList[j] = sortedList[j + 1];
                        sortedList[j + 1] = temp;
                    }
                }
            }

            return sortedList;
        }
    }
}





