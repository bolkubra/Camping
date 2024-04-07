using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CampPlaceDetailDto : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string CampName { get; set; }
        public string Contents { get; set; }
        public string Location { get; set; }
    }
}
