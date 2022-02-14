using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Integ_1
{
    public class Auto
    {
        public string _Patente { get; set; }
        public string _Marca { get; set; }
        public string _Modelo { get; set; }
        public string _Año { get; set; }
        public decimal _Precio { get; set; }
        public Persona Persona { get; }

        public Auto(string Patente, string Marca, string Modelo, string Año, decimal Precio)
        {
            _Patente = Patente;
            _Marca = Marca;
            _Modelo = Modelo;
            _Año = Año;
            _Precio = Precio;
        }

        ~Auto()
        {
        }

        //public Persona Dueño()
        //{
        //    return Persona;
        //}
    }
}

//Métodos
//Dueño Persona Retorna el dueño del auto.

//Constructores: Un constructor con todos los parámetros que permiten inicializar
//propiedades.

//Finalizador: Que cuando el objeto queda liberado muestre una leyenda indicando la
//Patente del Auto.


