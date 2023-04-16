using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class PrintVacations
    {
        public void Print(Dates dates)
        {
            foreach (var VacationList in dates.EmployeeVacations)
            {
                dates.SetDateList = VacationList.Value;
                Console.WriteLine($"Дни отпуска {VacationList.Key} : ");
                for (int i = 0; i < dates.SetDateList.Count; i++)
                {
                    Console.WriteLine(dates.SetDateList[i]);
                }
            }
        }
    }
}
