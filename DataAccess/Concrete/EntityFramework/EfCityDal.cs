using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : ICityDal
    {
        public void Add(City entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public City Get(Expression<Func<City, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll(Expression<Func<City, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
