using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LearnEF.Data
{
    interface IRepository<T> where T  : class
    {
        IQueryable<T> GetAllList(Expression<Func<T,bool>> predicate =null);
    }
}
