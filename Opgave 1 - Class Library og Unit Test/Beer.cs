using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1___Class_Library_og_Unit_Test
{
    public class Beer
    {

        // Properties
        public int Id { get; set; } 
        public string Name { get; set; }
        public int ABV { get; set; }

        // Constructor
        public Beer(int id, string name, int abv)
        {
            Id = id;
            Name = name;
            ABV = abv;
        }

        // To String method
        public override string ToString()
        {
            return$"Id: {Id}, Name: {Name}, ABV: {ABV}";
        }


        // Validation methods
        public void ValidateName()
        {
           
            if (Name == null)
            {
                throw new ArgumentNullException("Name must not be null.");
            }
            if (Name.Length < 3)
            {
                throw new ArgumentException("Name must be at least 3 characters long.");
            }

        }

        public void ValidateABV()
        {
            if (ABV < 0 || ABV > 67)
            {
                throw new ArgumentOutOfRangeException("ABV must be between 0 and 67.");
            }
        }

        // Method that validates the properties of the Beer object.
        // Then, it calls the validation methods.

        public void Validate()
        {
            ValidateName();
            ValidateABV();
        }

    }

    
}
