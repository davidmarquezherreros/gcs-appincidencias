using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class MasterPage : MasterDetailPage
	{
		public Usuario user;
		public MasterPage()
		{
			InitializeComponent();
			ocultarMostrarBotonera();
				
			// Poner la pagina home aqui
			Detail = new NavigationPage(new Registro()); // Esta vista es la que se carga por defecto
		}
		void Handle_Clicked(object sender, System.EventArgs e) // Lanza la vista de registro
		{
			Detail = new NavigationPage(new Registro());
		}

		void Handle_Clicked1(object sender, System.EventArgs e) // Lanza la vista de login
		{
			if (user == null) { Detail = new NavigationPage(new Login()); }
			else {Detail = new NavigationPage(new Login(user));  }
		}

		void Handle_Clicked2(object sender, System.EventArgs e) // Lanza la vista de limpieza
		{
			// De momento se carga la vista de alta orden limpieza cambiarla a la vista de limpieza cuando se haya creado
			Detail = new NavigationPage(new Limpieza(user));
		}

		void Handle_Clicked3(object sender, System.EventArgs e) // Lanza la vista de mantenimiento
		{
			Detail = new NavigationPage(new Mantenimiento(user));
		}

		void Handle_Clicked4(object sender, System.EventArgs e) // Lanza la vista de inventario
		{
			Detail = new NavigationPage(new GestionInventario(user));
		}

		void Handle_Clicked5(object sender, System.EventArgs e) // boton fichar
		{
			throw new NotImplementedException();
		}

		void Handle_Clicked6(object sender, System.EventArgs e) // boton salir
		{
			user.Logueado = false;
			ocultarMostrarBotonera();
			Detail = new NavigationPage(new Login(user));
		}

		public void ocultarMostrarBotonera()
		{
			//Cuando está logueado el usuario
			if (user != null && user.Logueado)
			{
				BtnLogin.IsVisible = false;
				BtnRegistro.IsVisible = false;
				BtnLimpieza.IsVisible = true;
				BtnMantenimiento.IsVisible = true;
				BtnInventario.IsVisible = true;
				BtnFichar.IsVisible = true;
				BtnSalir.IsVisible = true;
			}
			//Cuando no está logueado
			else
			{
				BtnLogin.IsVisible = true;
				BtnRegistro.IsVisible = true;
				BtnLimpieza.IsVisible = false;
				BtnMantenimiento.IsVisible = false;
				BtnInventario.IsVisible = false;
				BtnFichar.IsVisible = false;
				BtnSalir.IsVisible = false;
			}
		}
	}
}
