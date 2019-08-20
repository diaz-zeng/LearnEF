using System.Collections.Generic;
using LearnEf.Domains;

namespace LearnEF.Domains
{
    public class City
    {
        public City()
        {
            CompanyCities = new List<CompanyCity>();
        }

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public List<CompanyCity> CompanyCities
        {
            get;
            set;
        }

    }
}