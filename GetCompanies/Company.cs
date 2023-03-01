using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCompanies
{
    public class Company
    {
        public string Company_number { get; set; }
        public DateTime Date_of_creation { get; set; }
        public string Company_name { get; set; }
        public CompanyAdress Registered_office_address { get; set; }
        public string Company_status { get; set; }
        public string Company_status_detail { get; set; }
        public bool Has_been_liquidated { get; set; }
        public bool Has_charges { get; set; }
        public bool Has_insolvency_history { get; set; }
        public string Insolvency_case_type { get; set; }
        public string Insolvency_case_date_type { get; set; }
        public string Jurisdiction { get; set; }
        public string Identification_type { get; set; }
        public string[] Sic_codes { get; set; }
        public DateTime Date_of_cessation { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            string codes = "";
            if (Sic_codes != null)
            {
                if (Sic_codes.Length > 0)
                {
                    for (int i = 0; i < Sic_codes.Length; i++)
                    {
                        codes += Sic_codes[i];
                        codes += "; ";
                    }
                }
            }
            return "Number: " + Company_number + "\n" +
                "Name: " + Company_name + "\n" +
                "Type: " + Type + "\n" +
                "Adress: " + Registered_office_address.ToString() + "\n" +
                "Jurisdiction: " + Jurisdiction + "\n" +
                "Date of registration: " + Date_of_creation + "\n" +
                "Date of cessation: " + Date_of_cessation + "\n" +
                "Status: " + Company_status + "\n" +
                "Status detail: " + Company_status_detail + "\n" +
                "Is liquidated: " + Has_been_liquidated + "\n" +
                "Has charges: " + Has_charges + "\n" +
                "Has insolvency history: " + Has_insolvency_history + "\n" +
                "Case of insolvency: " + Insolvency_case_type + "\n" +
                "Date of insolvency`s case: " + Insolvency_case_date_type + "\n" +
                "SIC codes: " + codes + "\n" +
                "Identification type: " + Identification_type;
        }
    }
}
