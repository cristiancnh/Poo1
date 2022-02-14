using Act_Integ_1.Entidades;
using Act_Integ_1.Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_Integ_1
{

    public partial class Form1 : Form
    {
        IPersonaRepository personaRepository;
        IAutoRepository autoRepository;

        public Form1(IPersonaRepository personaRepository)//, IAutoRepository autoRepository)
        {
            this.personaRepository = personaRepository;
            //this.autoRepository = autoRepository;

            InitializeComponent();
        }

        private void Cmd_P_Agregar_Click(object sender, EventArgs e)
        {
            personaRepository.AgregarPersona();
        }
        private void Cmd_P_Asignar_Click(object sender, EventArgs e)
        {

        }
    }
}
