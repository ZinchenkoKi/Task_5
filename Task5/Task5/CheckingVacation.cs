using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class CheckingVacation
    {
        public bool Checking(Dates dates, DateTime startDate, DateTime endDate)
        {
            bool canCreateVacation = false;
            bool existStart = false;
            bool existEnd = false;

            if (!dates.Vacations.Any(element => element >= startDate && element <= endDate))
            {
                if (!dates.Vacations.Any(element => element.AddDays(3) >= startDate && element.AddDays(3) <= endDate))
                {
                    existStart = dates.DateList.Any(element => element.AddMonths(1) >= startDate && element.AddMonths(1) >= endDate);
                    existEnd = dates.DateList.Any(element => element.AddMonths(-1) <= startDate && element.AddMonths(-1) <= endDate);
                    if (!existStart || !existEnd)
                        canCreateVacation = true;
                }
            }
            return canCreateVacation;
        }
    }
}
