using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class MasterPage : MasterDetailPage
	{

		public MasterPage()
		{
			InitializeComponent();
			// Poner la pagina home aqui
			Detail = new NavigationPage(new Registro()); // Esta vista es la que se carga por defecto

		}
		void Handle_Clicked(object sender, System.EventArgs e) // Lanza la vista de registro
		{
			Detail = new NavigationPage(new Registro());
		}

		void Handle_Clicked1(object sender, System.EventArgs e) // Lanza la vista de login
		{
			Detail = new NavigationPage(new Login());
		}

		void Handle_Clicked2(object sender, System.EventArgs e) // Lanza la vista de limpieza
		{
			// De momento se carga la vista de alta orden limpieza cambiarla a la vista de limpieza cuando se haya creado
			Detail = new NavigationPage(new Limpieza());
		}

		void Handle_Clicked3(object sender, System.EventArgs e) // Lanza la vista de mantenimiento
		{
			Detail = new NavigationPage(new Mantenimiento());
		}

		void Handle_Clicked4(object sender, System.EventArgs e) // Lanza la vista de inventario
		{
			Detail = new NavigationPage(new GestionInventario());
		}

		void Handle_Clicked5(object sender, System.EventArgs e) // boton fichar
		{
			throw new NotImplementedException();
		}

		void Handle_Clicked6(object sender, System.EventArgs e) // boton salir
		{
			throw new NotImplementedException();
		}
	}
}
