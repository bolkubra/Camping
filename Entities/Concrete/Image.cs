﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int CampId { get; set; }
    }
}
