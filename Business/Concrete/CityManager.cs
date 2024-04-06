using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
       

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }



        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(Messages.CityAdded);
        }

        public IDataResult< List<City>> GetAll()
        {
            return  new DataResult<List<City>>( _cityDal.GetAll(),true,"City Listed");
        }

        public List<CityDetailDto> GetCityDetails()
        {
           return _cityDal.GetCityDetails();
        }
    }
}
