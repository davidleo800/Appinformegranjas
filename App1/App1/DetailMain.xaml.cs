﻿namespace AppInformeGranjas
{
    using AppInformeGranjas.View;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailMain : ContentPage
    {
        public DetailMain()
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