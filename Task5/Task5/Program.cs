using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dates dates = new Dates()
            {
                WorkingDays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },
                EmployeeVacations = new Dictionary<string, List<DateTime>>
                {
                    ["Иванов Иван Иванович"] = new List<DateTime>(),
                    ["Петров Петр Петрович"] = new List<DateTime>(),
                    ["Юлина Юлия Юлиановна"] = new List<DateTime>(),
                    ["Сидоров Сидор Сидорович"] = new List<DateTime>(),
                    ["Павлов Павел Павлович"] = new List<DateTime>(),
                    ["Георгиев Георг Георгиевич"] = new List<DateTime>()
                },
                Vacations = new List<DateTime>(),
                DateList = new List<DateTime>(),
                SetDateList = new List<DateTime>(),
                AllVacationCount = 0,
                VacationCount = 0
            };

            Vacations vacations = new Vacations();
            vacations.CalculationVacations(dates);

            Console.ReadKey();
        }
    }
}
