using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Models
{
    public class Libro
    {
        public class Root
        {
            public string _id { get; set; }
            public string nombre { get; set; }
            public int paginas { get; set; }
            public string autor { get; set; }
            public string editorial { get; set; }
            public string portada_url { get; set; }
            public string genero { get; set; }
            public string sinopsis { get; set; }
            public DateTime _created { get; set; }
            public DateTime _changed { get; set; }
            public string _createdby { get; set; }
            public string _changedby { get; set; }
            public int _version { get; set; }
        }
    }
}
