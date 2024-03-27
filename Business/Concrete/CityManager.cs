using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public List<CityDetailDto> GetCityDetails()
        {
           return _cityDal.GetCityDetails();
        }
    }
}
