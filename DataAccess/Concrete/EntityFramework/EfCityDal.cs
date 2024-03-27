using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<City, CampingProjectContext>, ICityDal
    {
        public List<CityDetailDto> GetCityDetails()
        {
            using (CampingProjectContext context = new CampingProjectContext())
            {
                var result = from c in context.Citys
                             join d in context.Districts
                             on c.CityId equals d.CityId
                             select new CityDetailDto
                             {CityName = c.CityName, DistrictName=d.DistinctName };

                return result.ToList();
            }
        }

    }
}
