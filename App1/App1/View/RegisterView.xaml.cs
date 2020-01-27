using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppInformeGranjas.Controller;
using AppInformeGranjas.Models;
using System.Diagnostics;

namespace AppInformeGranjas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterView : ContentPage
    {
        tb_login login = new tb_login();
        UserRepository userDB = new UserRepository();

        public RegisterView()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            CC.ReturnCommand = new Command(() => Nombre.Focus());
            Nombre.ReturnCommand = new Command(() => Apellido.Focus());
            Apellido.ReturnCommand = new Command(() => typeUser.Focus());

            btnLogin.Clicked += (sender, e) => {
                ((NavigationPage)this.Parent).PushAsync(new LoginView());
            };
        }

        private async void SignupValidation_ButtonClicked(object sender, EventArgs e)
        {
            if ((CC.Text == null) || ((Nombre.Text == null)) ||
                (Apellido.Text == null) || (typeUser.SelectedIndex == -1))
            {
                await DisplayAlert("Enter Data", "Enter Valid Data", "OK");
            }
            else {
                login.ID_CC = int.Parse(CC.Text);
                login.Apellido = Apellido.Text;
                login.Nombre = Nombre.Text;
                if (typeUser.SelectedIndex == 0)
                {
                    login.usuario = 1;
                }
                else {
                    login.usuario = 2;
                }
                try {

                    var retrunvalue = UserRepository.Instancia.AddUser(login);
                    if (retrunvalue == "Sucessfully Added")
                    {
                        await DisplayAlert("Usuario agregado", retrunvalue, "OK");
                        await Navigation.PushAsync(new LoginView());
                    }
                    else
                    {
                        await DisplayAlert("no User Add", retrunvalue, "OK");
                        CC.Text = string.Empty;
                        Nombre.Text = string.Empty;
                        Apellido.Text = string.Empty;
                    }
                } catch (Exception ex) {
                    Debug.WriteLine(ex);
                }
            }
        }

    }
}