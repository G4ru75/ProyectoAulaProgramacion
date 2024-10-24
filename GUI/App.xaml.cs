using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GUI
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Habilitar estilos visuales de Windows Forms (necesario para formularios de Windows Forms)
            System.Windows.Forms.Application.EnableVisualStyles();

            // Crear una instancia de la ventana de Windows Forms (gui.cs)
            gui formWindow = new gui(); // Asegúrate de que "GuiForm" es el nombre de la clase en gui.cs
            formWindow.Show();
        }
    }
}
