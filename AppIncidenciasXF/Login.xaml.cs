using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIncidenciasXF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Usuario usuario;
		public Login()
		{
			InitializeComponent();
		}

		public Login(Usuario user)
		{
			InitializeComponent();
			usuario = user;

			//Ya que pasamos desde registro los datos del usuario, auto-rellenamos
			//para mayor navegabilidad
			EntryNick.Text = user.Nick;
			EntryPassword.Text = user.Password;
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{

			Boolean camposConValor = true;

			if (EntryNick.Text == null || EntryPassword.Text == null)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					DisplayAlert("Error", "Los campos no pueden estar vacíos. Vuelve a intentarlo.", "OK");
				});
				camposConValor = false;
			}

			//Si los campos tienen datos, procedemos a validarlos, 
			//todavía no es seguro que pueda introducirse
			if (camposConValor)
			{

				//Nos aseguramos de verdad que viene de registro
				if (usuario != null)
				{
					//Comprobamos que sea igual lo introducido por teclado con lo pasado desde registro
					if (EntryNick.Text == usuario.Nick && EntryPassword.Text == usuario.Password)
					{
						//Establecemos el usuario como logueado
						usuario.Logueado = true;

						//Comprobamos según el tipo de usuario que sea a qué vista accedo
						//Tomamos por defecto la vista de Limpieza, tanto para conserjes, 
						//admin o limpiadores ya que no existe ni el home admin ni vista para conserjes
						//Usuario mantenimiento
						if (usuario.Type.Equals("1"))
						{
							//Pasamos a la vista de mantenimiento el usuario registrado
							var secondPage = new Mantenimiento(usuario);
							secondPage.BindingContext = usuario;
							await Navigation.PushAsync(secondPage);
						}
						else
						{
							//Pasamos a la vista de limpieza el usuario registrado
							var secondPage = new Limpieza(usuario);
							secondPage.BindingContext = usuario;
							await Navigation.PushAsync(secondPage);
						}

						//Actualizamos la MasterPage con el usuario que va a iniciar sesión
						//para que al pinchar en cualquier opción del menú no provoque un error
						App app = Application.Current as App;
						MasterPage mp = (MasterPage)app.MainPage;
						mp.user = usuario;
						mp.ocultarMostrarBotonera();
					}
					else
					{
						Device.BeginInvokeOnMainThread(() =>
						{
							DisplayAlert("Error", "Los datos introducidos no son correctos. Introduce los mismos datos de tu registro.", "OK");
						});
					}
				}
				else
				{
					Device.BeginInvokeOnMainThread(() =>
					{
						DisplayAlert("Error", "Debes haberte registrado antes.", "OK");
					});
				}

			}


		}
	}
}
