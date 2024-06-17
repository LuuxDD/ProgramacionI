using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Repositories
{
    public class LibrosRepository
    {
        string urlApi = "https://ingenieriasoftware-9437.restdb.io/home/db/ingenieriasoftware-9437/cards ";
        HttpClient client = new HttpClient();

        public LibrosRepository()
        {
            //Configuramos que trabajara con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("ApiKay ", "64aeea7da1ce30200009bc63");
        }
    }
}
