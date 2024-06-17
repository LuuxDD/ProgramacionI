using EjerciciosDePrueba.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        public async Task<ObservableCollection<Libro>?> ObtenerLibrosAsync()
        {
            var response = await client.GetAsync(urlApi);
            return JsonConverter.DeserializeObject<ObservableCollection<Libro>>(response);
        }

        public async Task<Libro?> AgregarAsync(string nombre, int paginas, string autor, string editorial, string portadaUrl, string genero, string sinopsis)
        {
            //Creamos un objeto del tipo libro con los parametrosque llegan 
            Libro libro = new Libro();
            {
                    nombre = nombre,
                    paginas = paginas,
                    autor = autor,
                    editorial= editorial,
                    portadaUrl= portadaUrl,
                    genero = genero,
                    sinopsis = sinopsis

            };

            //Enviamos por post el objeto que creamos a la URL de la API

            var librojson = new StringContent(
                JsonConverter.SerializeObject(libro),
                Encoding.UTF8, "aplication/json");
            var response = await client.PostAsync(urlApi, librojson);

            //
        }
    }
}
