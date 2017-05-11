using GeneticAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map.Repositories
{
    public class PassangerRepository
    {
        public List<Passanger> GetPassangers(int count)
        {
            var passangerList = new List<Passanger>();

            for (int i = 1; i <= count; ++i)
            {
                passangerList.Add(new Passanger() { EntetyId = i, StartPoint = i, EndPoint = ++i, Count = 2});
            }

            return passangerList;
        }
    }
}