using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentHelpService
{
    public class Interview
    {
        public string InterviewDate { get; set; }

        // Interview constructor a method to initialize new interview object
        public Interview(string interviewDate)
        {
            InterviewDate = interviewDate;
        }

    }

   
}
