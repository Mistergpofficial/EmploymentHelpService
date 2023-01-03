using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentHelpService
{
    public class Vacancy
    {
        public string StartDate { get; set; }
        public float Salary { get; set; }
        public string TypeOfWork { get; set; }
        public string MinimumQualification { get; set; }
        public string Experience { get; set; }
        public int Distance { get; set; }

        public string DriversLicense { get; set; }

        public string checkUnspentCriminalRecord { get; set; }

    



        // Vacancy constructor a method to initialize new Vacancy objects

        public Vacancy(string typeofwork, string qualification, string startdate, string criminalrecord, float salary, string license, string experience, int distance)
        {
            StartDate = startdate;
            Salary = salary;
            TypeOfWork = typeofwork;
            MinimumQualification = qualification;
            Experience = experience;
            checkUnspentCriminalRecord = criminalrecord;
            DriversLicense = license;
            Distance = distance;
        }
    }
}
