using GeneticAlgorithm;
using Map.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map.Repositories
{
    public class CarRepository
    {
        public List<Car> GetCars()
        {
            var cars = new List<Car> {
                new Car{ EntetyId = 0, StartPoint = 0, Capacity = 4, Price = 100, Lat = 40.71, Lng = -74.01}
            };

            return cars;
        }
    }
}