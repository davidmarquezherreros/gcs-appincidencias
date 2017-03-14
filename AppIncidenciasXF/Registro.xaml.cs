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

		public Registro(Usuario user) 
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			Boolean ok = true;
			if (EntryNick.Text == null || EntryNombre.Text == null || EntryApellidos.Text == null || EntryEmail.Text == null || EntryPassword.Text == null || EntryTelefono.Text == null || PickerType.SelectedIndex==-1)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					DisplayAlert("Error", "Los campos no pueden estar vacios", "OK");
				});
				ok = false;
			}
			if(ok==true)
			{
				var usuario = new Usuario
				{
					Nick = EntryNick.Text,
					Name = EntryNombre.Text,
					Surname = EntryApellidos.Text,
					Email = EntryEmail.Text,
					Password = EntryPassword.Text,
					Type = PickerType.SelectedIndex.ToString(),
					PhoneNumber = EntryTelefono.Text
				};
				var secondPage = new Login(usuario);
				secondPage.BindingContext = usuario;
				await Navigation.PushAsync(secondPage);
			}
		}
	}
}
