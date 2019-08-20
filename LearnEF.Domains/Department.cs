using System;

namespace LearnEF.Domains
{
    public class Department
    {
        public Department()
        {

        }

        public Company Company
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public int CompanyId
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }
    }
}