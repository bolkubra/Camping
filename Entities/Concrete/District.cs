using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class District : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int DistinctName { get; set; }
    }
}
