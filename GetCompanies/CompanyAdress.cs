using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCompanies
{
    public class CompanyAdress
    {
        public string Postal_code { get; set; }
        public string Address_line_2 { get; set; }
        public string Country { get; set; }
        public string Address_line_1 { get; set; }
        public string Locality { get; set; }

        public override string ToString()
        {
            return Postal_code + ", " + Address_line_1 + ", " + Address_line_2 + ", " + Locality + ", " + Country;
        }
    }
}
