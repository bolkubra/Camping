using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        
        public IDataResult<CampPlace> GetById(int cityId)
        {
            return new SuccessDataResult<CampPlace>(_campPlaceDal.Get(c => c.CityId == cityId));
        }

        public IDataResult<List<CampPlace>> GetAll()
        {
            return new DataResult<List<CampPlace>>(_campPlaceDal.GetAll(), true, "CampPlace Listed");
        }

     

        public IDataResult<List<CampPlaceDetailDto>> GetCampPalceDetails(int cityId)
        {
            var campPlaces = _campPlaceDal.GetCampPlaceDetails(cityId); // _campPlaceDal'dan belirli cityId'ye sahip kamplama yerlerini al
            var campPlaceDetails = campPlaces.Select(cp => new CampPlaceDetailDto
            {
                Id = cp.Id,
                CityId = cp.CityId,
                CityName = cp.CityName,
                DistrictId = cp.DistrictId,
                DistrictName = cp.DistrictName,
                CampName = cp.CampName,
                Contents = cp.Contents,
                Location = cp.Location
            }).ToList();

            return new SuccessDataResult<List<CampPlaceDetailDto>>(campPlaceDetails, "Kamp yerleri listelendi.");
        }
    }
}
