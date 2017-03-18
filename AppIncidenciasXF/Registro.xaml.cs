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
					DisplayAlert("Error", "Los campos no pueden estar vacíos", "OK");
				});
				ok = false;
			}
			//Si sigue siendo válido, comprobamos el teléfono
			if (ok)
			{
				if (this.IsValidPhone(EntryTelefono.Text) == false)
				{
					Device.BeginInvokeOnMainThread(() =>
					{
						DisplayAlert("Error", "El número de telefono introducido no es válido", "OK");
					});
					ok = false;
				}
				//Si sigue siendo válido, comprobamos el email
				if (ok) {
					if (IsValidEmail(EntryEmail.Text) == false)
					{
						Device.BeginInvokeOnMainThread(() =>
						{
							DisplayAlert("Error", "El email introducido no es válido", "OK");
						});
						ok = false;
					}

					//Si es válido del todo
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
			}
		}
		public bool IsValidPhone(string phone)
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
