﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppInformeGranjas.Models;
using Android.Widget;

namespace AppInformeGranjas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewVeterinario : ContentPage
    {
        public ViewVeterinario()
        {
            InitializeComponent();
			NavigationPage.SetHasBackButton(this, false);
		}


		private async void listaRegistros()
		{
			/*
		try {
		ManagerMort manager = new ManagerMort();
		var res = await manager.getMoritalidad();

				if (res != null) {
		lstMort.ItemsSource = res;
		}
		}
				catch (Exception e1) {

		}*/
		}

		private void btnConsult_Clicked(object sender, EventArgs e)
		{
			var allDetalle = UserRepository.Instancia.GetAllDetalle();
			lstDetalles.ItemsSource = allDetalle;


			var context = Android.App.Application.Context;
			Toast.MakeText(context, UserRepository.Instancia.EstadoMensaje,
				ToastLength.Long).Show();
		}
	}
}