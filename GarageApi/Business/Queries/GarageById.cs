﻿using GarageApi.Business.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GarageApi.Business.Queries
{
    public class GarageById : IQuery<Domain.Garage>
    {
        public int Id { get; }

        public GarageById(int id)
        {
            Id = id;
        }

        public Domain.Garage Execute(IDataAccess dataAccess)
        {
            dynamic @object = dataAccess.Query<Garage>(
                g => g.Id == Id,
                g => new {g.Id, g.Name, Vehicles = g.Vehicles.Select(v => v.RegNo).ToArray()}).SingleOrDefault();

            if (@object == null)
            {
                throw new KeyNotFoundException();
            }

            var vehicles = ((IEnumerable<string>) @object.Vehicles)?.Select(regNo => new Domain.Vehicle(regNo));
            var domainGarage = new Domain.Garage(@object.Id, @object.Name, vehicles);

            return domainGarage;

        }
    }
}