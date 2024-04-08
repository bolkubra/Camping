using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICapmPlaceService
    {
       IDataResult< List<CampPlace>> GetAll();
       public List<CampPlaceDetailDto> GetCampPalceDetails(int cityId);
    }
}
