using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clase
{
    internal class PavaElectrica
    {
        //Declarar campos
        private string marca;
        private bool encendido;

        //Propiedades 
        public int Temperatura = 50;

        public PavaElectrica(string marca)

        {
            this.marca = marca;
        }

        public void PresionarBotonEncendido()
        {
            this.encendido = !this.encendido;
            Console.WriteLine("Lista para usar");
            //sujeto a modificaciones 
        }

        public void CambiarModo()
        {
            if (Temperatura == 80)
                Console.WriteLine("Mate");
            else if (Temperatura == 100)
                Console.WriteLine("Te"); 
            else Console.WriteLine("Al Agua le falta temperatura");
            
                 
               
        }
    }


}
