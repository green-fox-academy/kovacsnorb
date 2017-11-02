using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonWebapp.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public User()
        {
            Pokemons = new List<Pokemon>();
        }
    }
}
