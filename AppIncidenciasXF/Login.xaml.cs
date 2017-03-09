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
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			var secondPage = new Limpieza(usuario);
			secondPage.BindingContext = usuario;
			await Navigation.PushAsync(secondPage);

		}
    }
}
