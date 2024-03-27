using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICityDal : IEntityRepository<City>
    {
        List<CityDetailDto> GetCityDetails(); // city detayları getir DTO da yaptığımız sanal tabloya göre
    }
}
