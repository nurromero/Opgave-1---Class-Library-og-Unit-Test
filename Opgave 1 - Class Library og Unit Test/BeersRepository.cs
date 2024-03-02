using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1___Class_Library_og_Unit_Test
{
    public class BeersRepository
    {
        // Creating a list of Beer objects
        private List<Beer> _beers = new List<Beer>();

        //Property 
        private int _nextId = 1;

        // Constructor 
        public BeersRepository()
            
        {
            // Adding 6ish beer objects to the list
            _beers.Add(new Beer(1, "Tuborg", 5));
            _beers.Add(new Beer(2, "Mont Blanc", 5));
            _beers.Add(new Beer(3, "Elefant", 7));
            _beers.Add(new Beer(4, "Pilsner", 5));
            _beers.Add(new Beer(5, "Efes Pilsen", 5));
            _beers.Add(new Beer(6, "Marmara Gold", 6));
        }

        // Get that returns a copy of the list of all beer objects 
        public List<Beer> Get()
        {
            return new List<Beer>(_beers);
        }

        // Get that makes it possible to filtre on ABV
        public List<Beer> Get(int abv)
        {
            return _beers.FindAll(beer => beer.ABV == abv);
        }

        // Get, that makes it possible to sort on Name or ABV
        public List<Beer> Get(string sort)
        {
            if (sort == "Name")
            {
                return _beers.OrderBy(beer => beer.Name).ToList();
            }
            else if (sort == "ABV")
            {
                return _beers.OrderBy(beer => beer.ABV).ToList();
            }
            else
            {
                throw new ArgumentException("Invalid sort value");
            }
        }

        // GetById, that returns beer object with gtiven Id, or null
        // if null, FirstOrDefault method will return null indicating that no beer is found in the list
          public Beer GetById(int id)
        {
            return _beers.FirstOrDefault(beer => beer.Id == id);
        }      
        
        // Add method, that adds Id to beer + adding it to the list & returns it
        // _nextId++ is used to give the beer object a unique Id
        public Beer Add(Beer beer)
        {
            beer.Id = _nextId++;
            _beers.Add(beer);
            return beer;
        }

        // Delete method, deletes beer from object and returns it (or returning null)
        public Beer Delete(Beer beer)
        {
            var beerToDelete = _beers.FirstOrDefault(b => b.Id == beer.Id);
            if (beerToDelete != null)
            {
                _beers.Remove(beerToDelete);
                return beerToDelete;
            }
            else
            {
                return null;
            }
        }

        // Update method, updates beer with given Id with values
        // returns the updated beet object or null
        public Beer Update (int id, Beer beer)
        {
            var beerToUpdate = _beers.FirstOrDefault(b => b.Id == id);
            if (beerToUpdate != null)
            {
                beerToUpdate.Name = beer.Name;
                beerToUpdate.ABV = beer.ABV;
                return beerToUpdate;
            }
            else
            {
                return null;
            }
        }
    }
}

