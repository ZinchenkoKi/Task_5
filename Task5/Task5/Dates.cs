using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Dates
    {
       public List<string> WorkingDays { get; set; }
       public Dictionary<string, List<DateTime>> EmployeeVacations { get; set; }
       public List<DateTime> Vacations { get; set; }
       public int AllVacationCount { get; set; }
       public List<DateTime> DateList { get; set; }
       public List<DateTime> SetDateList { get; set; }
       public int VacationCount { get; set; }
    }
}
