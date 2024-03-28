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
        List<City> GetAll();
        public List<CityDetailDto> GetCityDetails();

        void  Add(City city);
    }
}
