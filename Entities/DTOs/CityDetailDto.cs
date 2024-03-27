using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CityDetailDto : IDto
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
    }
}
