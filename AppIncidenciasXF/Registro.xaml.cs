using System;

using Xamarin.Forms;
using System.Text.RegularExpressions;
using System.Net;

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
			if (EntryNick.Text == null || EntryNombre.Text == null || EntryApellidos.Text == null || EntryEmail.Text == null || EntryPassword.Text == null || EntryTelefono.Text == null || PickerType.SelectedIndex == -1)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					DisplayAlert("Error", "Los campos no pueden estar vacios", "OK");
				});
				ok = false;
			}
			if (IsValidPhone(EntryTelefono.Text) == false)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					DisplayAlert("Error", "El numero de telefono introducido no es valido", "OK");
				});
				ok = false;
			}
			if (IsValidEmail(EntryEmail.Text) == false)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					DisplayAlert("Error", "El email introducido no es valido", "OK");
				});
				ok = false;
			}
			if (ok == true)
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
		private bool IsValidPhone(string phone)
		{
			return phone.Length==9;
		}
		public bool IsValidEmail(string emailaddress)
		{
			Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(emailaddress);
			return match.Success;
		}
	}

}
