using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class AltaOrdenLimpieza : ContentPage
	{
		// Dictionary to get Color from color name.
		Dictionary<string, int> nameToColor = new Dictionary<string, int>
		{
			{ "Habitacion", 1 },{ "Habitacion", 2 },
			{ "Habitacion", 3 },{ "Habitacion", 4 }
		};
		public AltaOrdenLimpieza()
		{
			InitializeComponent();
		}
	}
}
