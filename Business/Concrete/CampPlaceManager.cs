using Business.Abstract;
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
    public class CampPlaceManager : ICapmPlaceService

    {

        ICampPlaceDal _campPlaceDal;
        public CampPlaceManager(ICampPlaceDal campPlaceDal)
        {
            _campPlaceDal = campPlaceDal;
        }


        public IDataResult<List<CampPlace>> GetAll()
        {
            return new DataResult<List<CampPlace>>(_campPlaceDal.GetAll(), true, "CampPlace Listed");
        }

        public List<CampPlaceDetailDto> GetCampPalceDetails(int cityId)
        {
            return _campPlaceDal.GetCampPlaceDetails(cityId);
        }
    }
}
