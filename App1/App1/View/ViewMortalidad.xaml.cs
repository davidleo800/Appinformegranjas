using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppInformeGranjas.Models;
using Xamarin.Plugin.Calendar.Models;
namespace AppInformeGranjas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewMortalidad : ContentPage
	{
		public ViewMortalidad ()
		{
			InitializeComponent ();
			listaRegistros();
			
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
		public EventCollection Events { get; private set; }


	}
}