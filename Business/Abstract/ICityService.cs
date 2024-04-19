using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //city ile ilgili dış dünyaya neler sergileyeceğimi burda listeleriz
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();

        IResult Add(City city);
        IResult Delete(City city);
        IResult Updated(City city);


        public List<CityDetailDto> GetCityDetails();

       
    }
}
