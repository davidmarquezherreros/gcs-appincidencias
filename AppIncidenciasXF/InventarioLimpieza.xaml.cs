using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class InventarioLimpieza : ContentPage
	{
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
	}
}
