using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Integ_1.Entidades
{
    public interface IPersonaRepository
    {
        void AgregarPersona();
        void QuitarPersona();
        List<Persona> ListarPersonas();
    }
}