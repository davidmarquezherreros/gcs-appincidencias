using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class AltaOrdenLimpieza : ContentPage
	{
		List<string> habitaciones = new List<string>
		{
			"Habitacion 1",
			"Habitacion 2",
			"Habitacion 3",
			"Habitacion 4",
			"Habitacion 5",
		};
		public List<string> Habitaciones => habitaciones;

		public AltaOrdenLimpieza()
		{
			InitializeComponent();
		}
	}
}
