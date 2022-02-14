using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Integ_1
{
    public class Persona
    {
        //atributos
        public int _Dni { get; set; }
        public string _Nombre { get; set; }
        public string _Apellido { get; set; }
        public List<Auto> Autos { get; set; }
        public int CantidadAutos { get { return Autos.Count(); } }

        //constructores
        public Persona(int Dni, string Nombre, string Apellido)
        {
            _Dni = Dni;
            _Nombre = Nombre;
            _Apellido = Apellido;
        }

        //destructores
        ~Persona()
        {
        }
    }
}

//List<Auto> autos = new List<Auto>();

//Métodos
//Lista_de_autos List<auto> Retorna la lista de autos que a persona es
//dueño.
//Cantidad_de_Autos int Retorna la cantidad de autos que posee la
//persona

//Constructores: Un constructor con todos los parámetros que permiten inicializar las
//propiedades.

//Finalizador: Que cuando el objeto queda liberado muestre una leyenda indicando el
//DNI de la Persona.


