using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class AltaProductoLimpieza : ContentPage
	{
		
		Usuario usuario;
		public AltaProductoLimpieza()
		{
			InitializeComponent();
		}
		public AltaProductoLimpieza(Usuario user)
		{
			InitializeComponent();
			usuario = user;
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			bool ok = true;
			if (EntryProduct.Text == null || EntryCantity.Text == null || DescripcionProduct.Text == null)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					DisplayAlert("Error", "Los campos no pueden estar vacios", "OK");
				});
				ok = false;
			}
			if (ok == true)
			{
				var producto = new Producto
				{
					Nombre = EntryProduct.Text,
					Cantidad = int.Parse(EntryCantity.Text),
					Descripcion = DescripcionProduct.Text,

				};
				usuario.addProductosLimpieza(producto);
				var secondPage = new InventarioLimpieza(usuario);
				secondPage.BindingContext = usuario;
				await Navigation.PushAsync(secondPage);
			}
		}
	}
}
