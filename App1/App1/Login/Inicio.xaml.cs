using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppInformeGranjas.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        private string nombreUsuario;
        public static string NombreUsuario;
        User model2 = new User(NombreUsuario);
        public Inicio()
        {
            nombreUsuario = model2.PruebaNombre();
            InitializeComponent();
        }
        public static string nombre = "";

        public User(string nombreU)
        {
            if (Application.Current.Properties.ContainsKey("name"))
            {
                var val = Application.Current.Properties["name"];
                nombre = val.ToString();
            }
            //nombre = AD_Login.NombreUsuario;
        }
        public string PruebaNombre()
        {
            return nombre;
        }
    }
}