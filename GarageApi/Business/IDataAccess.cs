using System;
using System.Linq.Expressions;

namespace GarageApi.Business
{
    public interface IDataAccess
    {
        object[] Query<T>(Expression<Func<T, bool>> filter, Expression<Func<T, object>> selector) where T : class;
    }
}