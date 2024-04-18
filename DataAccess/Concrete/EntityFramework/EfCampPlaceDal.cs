using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCampPlaceDal : EfEntityRepositoryBase<CampPlace, CampingProjectContext>, ICampPlaceDal
    {

        public List<CampPlaceDetailDto> GetCampPlaceDetails(int cityId)
        {
            using (CampingProjectContext context = new CampingProjectContext())
            {
                var result = from camp in context.CampPlaces
                             join city in context.Citys on camp.CityId equals city.CityId
                             where camp.CityId == cityId
                             select new CampPlaceDetailDto
                             {
                                 CityName = city.CityName,
                                 CampName = camp.CampName
                             };


                return result.ToList();
            }
        }
    }
}
