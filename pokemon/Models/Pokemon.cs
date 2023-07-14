using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pokemon.Models
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string nombrePokemon { get; set; }
        [JsonProperty("url")]
        public Uri link { get; set; } 
    }
}
