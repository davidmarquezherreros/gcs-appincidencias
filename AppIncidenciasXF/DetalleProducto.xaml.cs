using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class DetalleProducto : ContentPage
	{
		public DetalleProducto()
		{
			InitializeComponent();
		}

		public DetalleProducto(object producto,Usuario user)
		{
			InitializeComponent();
			Usuario u = user;
			Producto p=(Producto)producto;
			NombreProducto.Text = "Detalle Producto " + p.Nombre.ToString();
			CantidadProducto.Text = "Cantidad "+p.Cantidad.ToString();
			DescripcionProducto.Text = p.Descripcion.ToString();
			ActualizarProducto.Text="Cantidad " + p.Cantidad.ToString();
		}
	}
}
