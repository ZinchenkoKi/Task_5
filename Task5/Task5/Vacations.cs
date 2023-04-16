using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Vacations
    {
        public void CalculationVacations(Dates dates)
        {
            CheckingVacation checking = new CheckingVacation();
            PrintVacations vacations = new PrintVacations();

            foreach (var vacationList in dates.EmployeeVacations)
            {
                Random gen = new Random();
                Random step = new Random();
                DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime end = new DateTime(DateTime.Today.Year, 12, 31);
                dates.DateList = vacationList.Value;
                dates.VacationCount = 28;

                while (dates.VacationCount > 0)
                {
                    int range = (end - start).Days;
                    var startDate = start.AddDays(gen.Next(range));

                    if (dates.WorkingDays.Contains(startDate.DayOfWeek.ToString()))
                    {
                        string[] vacationSteps = { "7", "14" };
                        int vacIndex = gen.Next(vacationSteps.Length);
                        var endDate = new DateTime(DateTime.Now.Year, 12, 31);
                        float difference = 0;


                        if (vacationSteps[vacIndex] == "7")
                        {
                            endDate = startDate.AddDays(7);
                            difference = 7;
                        }
                        if (vacationSteps[vacIndex] == "14")
                        {
                            endDate = startDate.AddDays(14);
                            difference = 14;
                        }

                        if (dates.VacationCount <= 7)
                        {
                            endDate = startDate.AddDays(7);
                            difference = 7;
                        }
                        
                        if (checking.Checking(dates, startDate, endDate))
                        {
                            VacationRecord(dates, startDate, endDate, difference);
                        }
                    }
                }
            }

            vacations.Print(dates);
            Console.ReadKey();
        }

        private void AddingVacationDays(string number, DateTime startDate, DateTime endDate, float difference)
        {
            endDate = startDate.AddDays(Convert.ToInt32(number));
            difference = Convert.ToInt32(number);
        }

        private void VacationRecord(Dates dates, DateTime startDate, DateTime endDate, float difference)
        {
            for (DateTime dt = startDate; dt < endDate; dt = dt.AddDays(1))
            {
                dates.Vacations.Add(dt);
                dates.DateList.Add(dt);
            }
                dates.AllVacationCount++;
                dates.VacationCount -= (int)difference;
        }
    }
}
