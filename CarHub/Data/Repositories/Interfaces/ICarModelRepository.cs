﻿using CarHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarHub.Data.Repositories.Interfaces
{
    public interface ICarModelRepository
    {
        public List<CarModel> GetAllModelsByMake(int makeId);
    }
}
