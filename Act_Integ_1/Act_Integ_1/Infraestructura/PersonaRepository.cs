using Act_Integ_1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Integ_1.Infraestructura
{
    public class PersonaRepository : IPersonaRepository
    {
        public void AgregarPersona()
        {
            throw new NotImplementedException();
        }

        public List<Persona> ListarPersonas()
        {
            List<Persona> _personas = new List<Persona>();

            return _personas;
        }

        public void QuitarPersona()
        {
            throw new NotImplementedException();
        }
    }
}