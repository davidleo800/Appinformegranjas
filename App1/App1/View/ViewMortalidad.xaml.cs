using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppInformeGranjas.Models;

namespace AppInformeGranjas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewMortalidad : ContentPage
	{
		public ViewMortalidad()
		{
			InitializeComponent();
			listaRegistros();

			btn1.Clicked += (sender, e) => {
				((NavigationPage)this.Parent).PushAsync(new DataBase.DataPage());
			};
		}
		

		private async void listaRegistros() {

		try {
		ManagerMort manager = new ManagerMort();
		var res = await manager.getMoritalidad();

				if (res != null) {
		lstMort.ItemsSource = res;
		}
		}
				catch (Exception e1) {

		}
		}

	}
}
