using LearnEF.Domains;

namespace LearnEf.Domains
{
    public class CompanyCity
    {
        public int CompanyId { get; set; }
        public int CityId { get; set; }
        public Company Company { get; set; }
        public City City { get; set; }
    }
}