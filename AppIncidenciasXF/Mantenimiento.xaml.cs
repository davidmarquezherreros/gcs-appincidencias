using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
//using AppIncidenciasXF.ViewModels;
namespace AppIncidenciasXF
{
	public partial class Mantenimiento : ContentPage
	{
		Usuario usuario;
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (usuario == null)
			{
				Navigation.PushAsync(new DetalleMantenimiento());
			}
			else
			{
				Navigation.PushAsync(new DetalleMantenimiento(e.SelectedItem, usuario));
			}
		}

		public Mantenimiento()
		{
			InitializeComponent();

			MantenimientoListView.ItemsSource = new List<ElementsViewModel> {
				new ElementsViewModel {Name = "Habitacion 1"},
				new ElementsViewModel {Name = "Habitacion 2"},
				new ElementsViewModel {Name = "Habitacion 3"},
				new ElementsViewModel {Name = "Habitacion 4"},
				new ElementsViewModel {Name = "Habitacion 5"},
				new ElementsViewModel {Name = "Habitacion 6"},
				new ElementsViewModel {Name = "Habitacion 7"},
				new ElementsViewModel {Name = "Habitacion 8"}
			};
		}

		public Mantenimiento(Usuario user)
		{
			InitializeComponent();
			usuario = user;
			if (user.incidencia > 0)
			{
				cargarIncidenciasMantenimiento();
				if (usuario.incidencias.Length == 0)
				{
					Device.BeginInvokeOnMainThread(() =>
					{
						DisplayAlert("Error", "Los campos no pueden estar vacíos", "OK");
					});
				}
			}
		}

		public void cargarIncidenciasMantenimiento()
		{
			List<MantenimientoIncidencia> lista = new List<MantenimientoIncidencia>();
			for (int i = 0; i < usuario.incidencia; i++)
			{
				lista.Add(new MantenimientoIncidencia { Nombre = usuario.incidencias[i].Nombre, Detalle = usuario.incidencias[i].Observaciones });
			}
			MantenimientoListView.ItemsSource = lista;
		}

		void anyadirIncidenciaMantenimiento(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AltaOrdenMantenimiento(usuario));
		}

	}
}
