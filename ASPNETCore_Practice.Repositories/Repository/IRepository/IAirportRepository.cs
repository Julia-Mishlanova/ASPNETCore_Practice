﻿using ASPNETCore_Practice.Models.Domain;
using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.DataAccess.Repository.IRepository
{
    public interface IAirportRepository : IRepository<AirportDTO>
    {
        void Update(AirportDTO obj);
    }
}
