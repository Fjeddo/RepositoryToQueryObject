using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace GarageApi.Business
{
    public class DataAccess : DbContext, IDataAccess
    {
        public object[] Query<T>(Expression<Func<T, bool>> filter, Expression<Func<T, object>> selector) where T : class
        {
            return Set<T>().Where(filter).Select(selector).ToArray();
        }
    }
}