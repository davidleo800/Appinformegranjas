using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1;

namespace AppInformeGranjas.DataBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public DataPage()
        {
            InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fechaEntry.Text) && !string.IsNullOrWhiteSpace(mortalidadEntry.Text))
            {
                await App.Database.SavePersonAsync(new Mortalidad
                {
                    Fecha = fechaEntry.Text,
                    Mort = int.Parse(mortalidadEntry.Text)
                });

                fechaEntry.Text = mortalidadEntry.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
   
}