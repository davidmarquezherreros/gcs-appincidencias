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
		//public ObservableCollection<ElementsViewModel> elements { get; set; }
		public Mantenimiento()
		{
			InitializeComponent();
			//elements = new ObservableCollection<ElementsViewModel>();
			/*elements.Add(new ElementsViewModel

			{
				Name = "Habitacion 1"

			});
			elements.Add(new ElementsViewModel

			{
				Name = "Habitacion 2"

			});
			elements.Add(new ElementsViewModel

			{
				Name = "Habitacion 3"

			});

			elements.Add(new ElementsViewModel

			{
				Name = "Habitacion 4"

			});*/

			//MainListView.ItemsSource = elements;
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

			/*MainListView.ItemsSource = new List<String> { 
			
			  "Habitacion 1", "Habitacion 2", "Habitacion 3", "Habitacion 4", "Habitacion 5", "Habitacion 6", "Habitacion 7"
			};*/
		}
	}
}
