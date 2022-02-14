using Act_Integ_1.Entidades;
using Act_Integ_1.Infraestructura;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_Integ_1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IPersonaRepository, PersonaRepository>();

            serviceCollection.AddScoped<Form1>();

            var services = serviceCollection.BuildServiceProvider();

            var form1 = services.GetRequiredService<Form1>();
            Application.Run(form1);
        }
    }
}