using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppInformeGranjas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMain : ContentPage
    {
        public MasterMain()
        {
            InitializeComponent();
        }
        
        private async void btnIdentificar(object sender, EventArgs args)
        {
            var context = Android.App.Application.Context;
            Toast.MakeText(context, "Identificacion", ToastLength.Long).Show();
        }
    }
}