﻿using CarHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarHub.Data.Repositories.Interfaces
{
    public interface IFuelTypeRepository
    {
        public List<FuelType> GetAllFuelTypes();

        public string GetFuelTypeById(int id);

        public int ManageFuelType(FuelType fuelTypeObj);
    }
}
