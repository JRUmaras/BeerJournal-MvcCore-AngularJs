using System.Collections.Generic;
using System.Linq;
using BeerMvcAngularJs.Models;

namespace BeerMvcAngularJs.Services
{
    public class BeerService
    {
        public List<Beer> Beers { get; } = new List<Beer>
        {
            new Beer { Id = 0, Name = "Edelweiss" },
            new Beer { Id = 1, Name = "Warsteiner" },
            new Beer { Id = 2, Name = "Hoegaarden" }
        };

        public bool AddBeer(Beer newBeer)
        {
            Beers.Add(newBeer);
            return true;
        }

        public bool RemoveBeer(int id)
        {
            return Beers.RemoveAll(beer => beer.Id == id) > 0;
        }
    }
}
