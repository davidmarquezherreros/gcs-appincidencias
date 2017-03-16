using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class GestionInventario : ContentPage
	{
		private Usuario user;
		public GestionInventario()
		{
			InitializeComponent();
		}
		public GestionInventario(Usuario u)
		{
			InitializeComponent();
			user = u;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			if (user == null)
			{
				Navigation.PushAsync(new InventarioLimpieza());
			}
			else
			{
				Navigation.PushAsync(new InventarioLimpieza(user));
			}
		}

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			if (user == null)
			{
				Navigation.PushAsync(new InventarioMantenimiento());
			}
			else
			{
				Navigation.PushAsync(new InventarioMantenimiento(user));
			}
		}
	}
}
