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

		}
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Detail = new Registro();
		}

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
