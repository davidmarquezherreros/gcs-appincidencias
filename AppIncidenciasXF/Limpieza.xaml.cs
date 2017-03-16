using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class Limpieza : ContentPage
	{
		Usuario usuario;
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync(new DetalleHabitacion());
		}

		public Limpieza(Usuario user)
		{
			InitializeComponent();
			usuario = user;
			if (user.habitacion > 0)
			{
				cargarHabitaciones();
				if (usuario.habitaciones.Length == 0){
					Device.BeginInvokeOnMainThread(() =>
					{
						DisplayAlert("Error", "Los campos no pueden estar vacios", "OK");
					});
				}
			}
		}
		public void cargarHabitaciones()
		{
			List<LimpiezaViewModel> lista = new List<LimpiezaViewModel>();
			for (int i = 0; i < usuario.habitacion; i++)
			{
				lista.Add(new LimpiezaViewModel { Nombre = usuario.habitaciones[i].Nombre, Detalle = usuario.habitaciones[i].Horario });
			}
			LimpiezaListView.ItemsSource = lista;
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
			Navigation.PushAsync(new AltaOrdenLimpieza(usuario));
		}
	}
}
