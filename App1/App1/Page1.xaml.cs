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
    public partial class Page1 : ContentPage
    {


        public Page1()
        {
            InitializeComponent();
            btnSeguir.Clicked += BtnSeguir_Clicked;
        }

        private void BtnSeguir_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new DetailMain());
        }
    }
}
