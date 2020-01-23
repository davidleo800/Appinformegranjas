using App1;
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
    public partial class Login : ContentPage
    {
        public static string NombreUsuario = "Nicolas";
        ILoginManager iml = null;
        public Login (ILoginManager ilm)
        {
            InitializeComponent();
            iml = ilm;
        }
        void btnLoginClick (object sender, EventArgs e)
        {
            NombreUsuario = "Nicolas";
            App.Current.Properties["name"] = NombreUsuario;
            App.Current.Properties["IsLoggedIn"] = true;

            iml.ShowMainPage();
        }
    }
}