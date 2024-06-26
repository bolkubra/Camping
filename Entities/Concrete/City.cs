﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int NumberPlate { get; set; }
    }
}
