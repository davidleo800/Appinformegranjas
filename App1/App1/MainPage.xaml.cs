namespace App1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using AppInformeGranjas;
    using AppInformeGranjas.View;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Boton que redirige a vista formulario ViewMortalidad
            btnMort.Clicked += (sender, e) => {
                ((NavigationPage)this.Parent).PushAsync(new ViewMortalidad());
            };
            //Boton que redirige a vista formulario ViewBultosConsu
            btnBultos.Clicked += (sender, e) => {
                ((NavigationPage)this.Parent).PushAsync(new ViewBultosConsu());
            };
            //Boton que redirige a vista formulario ViewPesoPromedio
            btnPeso.Clicked += (sender, e) => {
                ((NavigationPage)this.Parent).PushAsync(new ViewPesoPromedio());
            };
        }
    }
    }

