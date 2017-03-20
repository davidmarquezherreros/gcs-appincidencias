using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class InventarioLimpieza : ContentPage
	{
		Usuario usuario;
		public InventarioLimpieza()
		{
			InitializeComponent();

			InventarioLimpiezaListView.ItemsSource = new List<InventarioLimpiezaModel> {
				new InventarioLimpiezaModel {Nombre = "Habitación 1", Detalle = "Detalle de habitación 1"},
				new InventarioLimpiezaModel {Nombre = "Habitación 2", Detalle = "Detalle de habitación 2"},
				new InventarioLimpiezaModel {Nombre = "Habitación 3", Detalle = "Detalle de habitación 3"},
				new InventarioLimpiezaModel {Nombre = "Habitación 4", Detalle = "Detalle de habitación 4"},
				new InventarioLimpiezaModel {Nombre = "Habitación 5", Detalle = "Detalle de habitación 5"},
				new InventarioLimpiezaModel {Nombre = "Habitación 6", Detalle = "Detalle de habitación 6"},
				new InventarioLimpiezaModel {Nombre = "Habitación 7", Detalle = "Detalle de habitación 7"},
				new InventarioLimpiezaModel {Nombre = "Habitación 8", Detalle = "Detalle de habitación 8"}
			};
		}
		public InventarioLimpieza(Usuario u)

		{
			InitializeComponent();
			usuario = u;
			if (usuario.proLimpieza > 0)
			{
				cargarProductos();
				if (usuario.productosLimpieza.Length == 0)
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
			for (int i = 0; i < usuario.proLimpieza; i++)
			{
				lista.Add(new Producto { Nombre = usuario.productosLimpieza[i].Nombre, Cantidad = usuario.productosLimpieza[i].Cantidad, Descripcion = usuario.productosLimpieza[i].Descripcion });
			}
			InventarioLimpiezaListView.ItemsSource = lista;
		}
		void Handle_ItemSelected(object sender, System.EventArgs e)
		{
			//Usuario usuario;

			Navigation.PushAsync(new DetalleProducto());
		}

		void anyadirProducto(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AltaProductoLimpieza(usuario));
		}
	}
}
