using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentHelpService
{
    public class Organisation
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
       
        public Organisation(string name, string address, string postcode)
        {
            Name = name;
            Address = address;
            PostCode = postcode;

        }

    }
}
