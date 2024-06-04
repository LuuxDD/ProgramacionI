using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clase
{
    internal class Split
    {
        //Declarar los campos

        private string color;
        private int frigorias;
        private string marca;
        private bool encendido = false;

        //Propiedades: Las variables publicas de la clase
        public int Temperatura = 24;
        public string Modo = "Frio";


        //Contrusctor: Metodo que se ejecuta cuando la clase se crea, se instancia en moemoria, es decir cuando se contruye el objeto
        public Split(string color, int frigorias, string marca)
        {
            this.color = color;
            this.frigorias = frigorias;
            this.marca = marca;
        }

        //Metodos, realizan una tarea especifica
        public void SubirTemperatura()
        {
            if (this.encendido)
            {
                this.Temperatura++;
            }
            else { Console.WriteLine("Error: El splist esta apagado "); }
        }

        public void BajarTemperatura()
        {

            if (this.encendido)
            {
                this.Temperatura--;
            }
            else
            {
                Console.WriteLine("Error: El splist esta apagado ");
            }
        }

        public void PresionarBotonEncendido()
        {
            this.encendido = !this.encendido;
        }

        public void CambiarModo(string modo)
        {
            if
                (this.encendido)
                this.Modo = modo;

            else
                Console.WriteLine("Error: el splir debe estar encendido ");

        }
    }
}
