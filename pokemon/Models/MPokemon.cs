using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pokemon.Models
{
    public class MPokemon
    {
        [JsonProperty("count")]
        public long cantidad { get; set; }
        [JsonProperty("next")]
        public Uri siguiente { get; set; }
        [JsonProperty("previous")]
        public object anterior { get; set; }
        [JsonProperty("results")]
        public List<Pokemon> pokemons { get; set; }
    }

   
}
