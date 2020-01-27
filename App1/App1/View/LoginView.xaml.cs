using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppInformeGranjas.Models;
using AppInformeGranjas.View;
namespace AppInformeGranjas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        UserRepository userData;
        public LoginView()
        {
            InitializeComponent();
            btnRegistrar.Clicked += (sender, e) => {
                ((NavigationPage)this.Parent).PushAsync(new RegisterView());
            };
            userData = new UserRepository();
            NavigationPage.SetHasBackButton(this, false);

        }
        
        
        private async void LoginValidation_ButtonClicked(object sender, EventArgs e)
        {
            var usuario = UserRepository.Instancia.usuarioValidate(int.Parse(CC.Text));
            if (CC.Text != null && usuario != 0)
            {
                var validData = UserRepository.Instancia.LoginValidate(int.Parse(CC.Text));
                if (validData)
                {
                    if (usuario == 1)
                    {
                        await Navigation.PushAsync(new ViewVeterinario());
                    }
                    else if (usuario == 2)
                    {

                        await Navigation.PushAsync(new ViewGalponero());
                    }
                    else {
                        await DisplayAlert("Fallo en inicio de sesión", "Documento incorrecto o no existe usuario", "OK");
                    }
                }
                else
                {
                    await DisplayAlert("Fallo en inicio de sesión", "Documento incorrecto o no existe usuario", "OK");
                }
            }
            else
            {
                await DisplayAlert("He He", "Ingrese su identificación", "OK");
            }
        }

        
    }
}