﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //city ile ilgili dış dünyaya neler sergileyeceğimi burda listeleriz
    public interface ICityService
    {
        List<City> GetAll();
    }
}
