using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class AltaProducto : ContentPage
	{
		Usuario usuario;
		public AltaProducto()
		{
			InitializeComponent();
		}
		public AltaProducto(Usuario user)
		{
			InitializeComponent();
			usuario = user;
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			bool ok = true;
			if (EntryProduct.Text == null || EntryCantity.Text == null || DescripcionProduct.Text==null)
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
				usuario.addProductos(producto);
				var secondPage = new InventarioMantenimiento(usuario);
				secondPage.BindingContext = usuario;
				await Navigation.PushAsync(secondPage);
			}
		}
	}
}
