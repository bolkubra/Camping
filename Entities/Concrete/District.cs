﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class District : IEntity
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistinctName { get; set; }
    }
}
