using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CampPlace :IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int DistinctId { get; set; }
        public string CampName { get; set; }
        public string Content { get; set; }
        public string Location { get; set; }
    }
}
