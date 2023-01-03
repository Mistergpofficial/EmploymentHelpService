using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentHelpService
{
    public class Client
    {
        // defining public properties with get and set methods.

        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string PostCode { get; set; }

        public string TypeofWork { get; set; }

        public int Distance { get; set; }

        public string DriversLicense { get; set; }

        public string UnspentCriminalRecord { get; set; }

        public string InterviewDate { get; set; }

        // public string InterviewDate { get; set; }


        public Client(string fullname, string address, string postcode, string email, string phone,  string typeofwork, int distance, string license, string criminalrecord, string interviewdate)
        {
            FullName = fullname;
            Address = address;
            Email = email;
            Phone = phone;
            PostCode = postcode;
            TypeofWork = typeofwork;
            Distance = distance;
            DriversLicense = license;
            UnspentCriminalRecord = criminalrecord;
            InterviewDate = interviewdate;


        }

    }
}
