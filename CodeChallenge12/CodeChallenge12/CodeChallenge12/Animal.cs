using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge12
{
    public  class Animal
    {

        public Animal(string species, string name)
        {
            Species = species;
             Name = name;
        }

        public string Name { get; set; }
        public string Species { get; set; }
    }
}
