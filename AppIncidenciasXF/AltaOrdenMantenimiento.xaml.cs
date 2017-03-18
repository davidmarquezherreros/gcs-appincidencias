﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class AltaOrdenMantenimiento : ContentPage
	{
		Usuario usuario;
		public AltaOrdenMantenimiento()
		{
			InitializeComponent();
		}

		public AltaOrdenMantenimiento(Usuario user)
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
					DisplayAlert("Error", "Los campos no pueden estar vacíos", "OK");
				});
				ok = false;
			}
			if (ok == true)
			{
				//Damos de alta la incidencia
				var orden = new MantenimientoIncidencia
				{
					Nombre = pickerhabitaciones.Items[pickerhabitaciones.SelectedIndex],
					Detalle = "DETALLE SIN IMPLEMENTAR" + pickerhabitaciones.Items[pickerhabitaciones.SelectedIndex],
					Horario = fecha.Date.ToString() + " " + hora.Time.ToString(),
					Encargado = pickerencargado.Items[pickerencargado.SelectedIndex],
					Observaciones = observaciones.Text
				};
				//Volvemos al listado de incidencias mantenimiento con la incidencia
				//ya asignada
				usuario.addMantenimientoIncidencia(orden);
				var secondPage = new Mantenimiento(usuario);
				secondPage.BindingContext = usuario;
				await Navigation.PushAsync(secondPage);
			}
		}
	}
}
