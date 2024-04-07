using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CampPlace :IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string CampName { get; set; }
        public string Contents { get; set; }
        public string Location { get; set; }
    }
}
