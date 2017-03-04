using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class GestionInventario : ContentPage
	{
		public GestionInventario()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new InventarioLimpieza());
		}

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new InventarioMantenimiento());
		}
	}
}
