using System;
using LearnEF.Domains;
using LearnEF.Data;
using System.Collections.Generic;
using System.Linq;

namespace LearnEF.UI
{
    public class Progarm
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start insert");
            //BatchInsert();
            //Console.WriteLine("End insert");
            //QueryAll();
            //QueryAllWithLinqFun();
            // QueryAllWithLinqQuery();
        }

        // private static void Insert()
        // {
        //     var company = new Company
        //     {
        //         Name = "Microsoft",
        //         StartDate = new DateTime(1975, 4, 4)

        //     };
        //     using (var context = new MyContext())
        //     {
        //         context.Companies.Add(company);
        //         context.SaveChanges();
        //     }
        // }

        // private static void BatchInsert()
        // {
        //     var google = new Company
        //     {
        //         Name = "Google",
        //     };
        //     var facebook = new Company
        //     {
        //         Name = "Facebook",
        //     };
        //     var beijing = new City
        //     {
        //         Name = "Beijing"
        //     };
        //     List<Object> list = new List<object>();
        //     list.Add(google);
        //     list.Add(facebook);
        //     list.Add(beijing);
        //     using (var context = new MyContext())
        //     {
        //         context.AddRange(list);
        //         context.SaveChanges();
        //     }
        // }

        // private static void QueryAll()
        // {
        //     using (var context = new MyContext())
        //     {
        //         var companies = context.Companies.ToList();
        //         companies.ForEach(Console.WriteLine);
        //     }
        // }

        // private static void QueryAllWithLinqFun()
        // {
        //     using (var context = new MyContext())
        //     {
        //         var companies = context.Companies.Where(x=>x.Id>2).ToList();
        //         companies.ForEach(Console.WriteLine);
        //     }
        // }

        // private static void QueryAllWithLinqQuery()
        // {
        //     using (var context = new MyContext())
        //     {
        //         var companies = (from x in context.Companies
        //                          where x.Id > 1
        //                          select x).ToList();
        //         companies.ForEach(Console.WriteLine);
        //     }
        // }
    }
}
