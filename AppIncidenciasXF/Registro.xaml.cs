using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class Registro : ContentPage
	{
		public Registro()
		{
			NavigationPage.SetBackButtonTitle(this, "Volver");
			NavigationPage.SetHasBackButton(this, true);
			NavigationPage.SetHasNavigationBar(this, true);
			InitializeComponent();
		}
	}
}
