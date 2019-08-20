using System;
using System.Collections.Generic;
using LearnEf.Domains;

namespace LearnEF.Domains
{
    public class Company
    {
        public Company()
        {
            Departments = new List<Department>();
            CompanyCities = new List<CompanyCity>();
        }

        public List<Department> Departments
        {
            get;
            set;
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

        public DateTime StartDate
        {
            get;
            set;
        }

        public List<CompanyCity> CompanyCities
        {
            get;
            set;
        }

        public Owner Owner
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType())
            {

                Company obj1 = obj as Company;
                return obj1.Id == Id;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}({this.Id})³ÉÁ¢ÓÚ:{this.StartDate:yyyy-MM-DD}";
        }
    }
}