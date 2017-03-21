using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class InventarioMantenimiento : ContentPage
	{
		Usuario usuario;
		public InventarioMantenimiento()
		{
			InitializeComponent();

			MantenimientoListView.ItemsSource = new List<InventarioMantenimientoModel> {
				new InventarioMantenimientoModel {Name = "Producto 1", Detalle ="Cantidad 20 unidades"},
				new InventarioMantenimientoModel {Name = "Producto 2", Detalle ="Cantidad 20 unidades"},
				new InventarioMantenimientoModel {Name = "Producto 3", Detalle ="Cantidad 20 unidades"},
				new InventarioMantenimientoModel {Name = "Producto 4", Detalle ="Cantidad 20 unidades"},
				new InventarioMantenimientoModel {Name = "Producto 5", Detalle ="Cantidad 20 unidades"},
				new InventarioMantenimientoModel {Name = "Producto 6", Detalle ="Cantidad 20 unidades"},
				new InventarioMantenimientoModel {Name = "Producto 7", Detalle ="Cantidad 20 unidades"},
				new InventarioMantenimientoModel {Name = "Producto 8", Detalle ="Cantidad 20 unidades"}

			};
		}
		public InventarioMantenimiento(Usuario u)
		{
			InitializeComponent();
			usuario = u;
			if (usuario.pro > 0)
			{
				cargarProductos();
				if (usuario.productos.Length == 0)
				{
					Device.BeginInvokeOnMainThread(() =>
					{
						DisplayAlert("Error", "Los campos no pueden estar vacíos", "OK");
					});
				}
			}
		}
		public void cargarProductos()
		{
			List<Producto> lista = new List<Producto>();
			for (int i = 0; i < usuario.pro; i++)
			{
				lista.Add(new Producto{ Nombre = usuario.productos[i].Nombre, Cantidad = usuario.productos[i].Cantidad ,Descripcion =usuario.productos[i].Descripcion});
			}
			MantenimientoListView.ItemsSource = lista;
		}
		void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs  e)
		{

			Navigation.PushAsync(new DetalleProducto(e.SelectedItem,usuario));
		}

		void anyadirProducto(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AltaProducto(usuario));
		}


	}
}
