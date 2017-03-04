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
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync(new DetalleMantenimiento()); 
		}

		//public ObservableCollection<ElementsViewModel> elements { get; set; }
		public Mantenimiento()
		{
			InitializeComponent();

			MainListView.ItemsSource = new List<ElementsViewModel> {
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

		void anyadirIncidenciaMantenimiento(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AltaOrdenMantenimiento());
		}

	}
}
