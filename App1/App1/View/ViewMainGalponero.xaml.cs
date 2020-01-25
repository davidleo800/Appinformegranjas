using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppInformeGranjas.Models;
using Android.Widget;

namespace AppInformeGranjas.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewBultosConsu : ContentPage
	{
		public ViewBultosConsu ()
		{
			InitializeComponent ();
		}

		private void btnInsert_Clicked(object sender, EventArgs e)
		{
			UserRepository.Instancia.AddnewDetalle(date.Date,
				int.Parse(txtGranja.Text), int.Parse(txtGalpon.Text),
				int.Parse(txtGalponero.Text), int.Parse(txtMort.Text), decimal.Parse(txtAlimento.Text),
				decimal.Parse(txtPeso.Text), int.Parse(txtVeterinario.Text));
			var context = Android.App.Application.Context;
			Toast.MakeText(context, UserRepository.Instancia.EstadoMensaje, ToastLength.Long).Show();
		}
	}
}