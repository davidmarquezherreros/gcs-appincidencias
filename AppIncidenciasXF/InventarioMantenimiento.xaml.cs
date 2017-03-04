using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class InventarioMantenimiento : ContentPage
	{

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

		void Handle_ItemSelected(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new DetalleProducto());
		}


	}
}
