using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Repositorios;

namespace InventarioEquiposFase3N
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var repositorioEmpleado = new RepositorioEmpleados();
            var empleadoController = new EmpleadoController(repositorioEmpleado);

            Application.Run(new frmPrincipal(empleadoController));
        }
    }
}