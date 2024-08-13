using EjerciciosDePrueba.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace EjerciciosDePrueba.Repositories
{
    public class LibrosRepository
    {
        string urlApi = "https://ingenieriasoftware-9437.restdb.io/home/db/ingenieriasoftware-9437/cards";
        HttpClient client = new HttpClient();

        public LibrosRepository()
        {
            // Configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("ApiKey", "64aeea7da1ce30200009bc63");
        }

        public async Task<ObservableCollection<Libro>?> ObtenerLibrosAsync()
        {
            var response = await client.GetAsync(urlApi);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Libro>>(json);
            }
            return null;
        }

        public async Task<Libro?> AgregarAsync(string nombre, int paginas, string autor, string editorial, string portadaUrl, string genero, string sinopsis)
        {
            // Creamos un objeto del tipo Libro con los parámetros que llegan
            Libro libro = new Libro
            {
                nombre = nombre,
                Paginas = paginas,
                Autor = autor,
                Editorial = editorial,
                PortadaUrl = portadaUrl,
                Genero = genero,
                Sinopsis = sinopsis
            };

            // Enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                JsonConvert.SerializeObject(libro),
                Encoding.UTF8, "application/json");

            var response = await client.PostAsync(urlApi, librojson);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Libro>(json);
            }
            return null;
        }
    }
}