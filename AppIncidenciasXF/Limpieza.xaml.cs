using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class Limpieza : ContentPage
	{
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			//Navigation.PushAsync(new DetalleHabitacion()); //HABILITAR CUANDO ESTE DetalleHabitacion
		}

		public Limpieza()
		{
			InitializeComponent();

			LimpiezaListView.ItemsSource = new List<LimpiezaViewModel> {
				new LimpiezaViewModel {Nombre = "Habitación 1", Detalle = "Detalle de habitación 1"},
				new LimpiezaViewModel {Nombre = "Habitación 2", Detalle = "Detalle de habitación 2"},
				new LimpiezaViewModel {Nombre = "Habitación 3", Detalle = "Detalle de habitación 3"},
				new LimpiezaViewModel {Nombre = "Habitación 4", Detalle = "Detalle de habitación 4"},
				new LimpiezaViewModel {Nombre = "Habitación 5", Detalle = "Detalle de habitación 5"},
				new LimpiezaViewModel {Nombre = "Habitación 6", Detalle = "Detalle de habitación 6"},
				new LimpiezaViewModel {Nombre = "Habitación 7", Detalle = "Detalle de habitación 7"},
				new LimpiezaViewModel {Nombre = "Habitación 8", Detalle = "Detalle de habitación 8"}
			};

		}

		void anyadirOrdenLimpieza(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AltaOrdenLimpieza());
		}
	}
}
