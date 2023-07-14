using Newtonsoft.Json;
using pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.Controllers
{
    public class ApiRequest
    {
        public string url { get; set; }
        private int actual = 0;
        public ApiRequest() {
            url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=";
        }

        public MPokemon Obternerlista() {
            var consulta = (HttpWebRequest)WebRequest.Create(url + actual);
            consulta.Method = "GET";
            consulta.ContentType = "application/json";
            consulta.Accept = "application/json";

            try
            {
                using (WebResponse response =consulta.GetResponse())
                {
                    if (Stream == null) {
                        return null;
                    }

                    using (StreamReader lector = new StreamReader(Stream)) {

                        string responseTexto = lector.ReadToEnd();
                        MPokemon pokelista = JsonConvert.DeserializeObject<MPokemon>(responseTexto);
                        actual = 10;
                        return pokelista;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        
        }

    }
}
