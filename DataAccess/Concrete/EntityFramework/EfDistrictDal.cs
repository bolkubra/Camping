using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDistrictDal : IDistrictDal
    {
        public void Add(District entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(District entity)
        {
            throw new NotImplementedException();
        }

        public District Get(Expression<Func<District, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<District> GetAll(Expression<Func<District, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(District entity)
        {
            throw new NotImplementedException();
        }
    }
}
