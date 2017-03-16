using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class AltaOrdenLimpieza : ContentPage
	{
		Usuario usuario;
		public AltaOrdenLimpieza()
		{
			InitializeComponent();
		}
		public AltaOrdenLimpieza(Usuario user)
		{
			InitializeComponent();
			usuario = user;
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			bool ok = true;
			if (pickerhabitaciones.SelectedIndex == -1 || pickerencargado.SelectedIndex == -1 || pickerencargado.SelectedIndex == -1)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					DisplayAlert("Error", "Los campos no pueden estar vacios", "OK");
				});
				ok = false;
			}
			if (ok == true)
			{
				var orden = new Habitacion
				{
					Nombre = pickerhabitaciones.Items[pickerhabitaciones.SelectedIndex],
					Horario = fecha.Date.ToString()+" "+hora.Time.ToString(),
					Encargado = pickerencargado.SelectedIndex.ToString(),
				};
				usuario.addHabitacion(orden);
				var secondPage = new Limpieza(usuario);
				secondPage.BindingContext = usuario;
				await Navigation.PushAsync(secondPage);
			}
		}
	}
}
