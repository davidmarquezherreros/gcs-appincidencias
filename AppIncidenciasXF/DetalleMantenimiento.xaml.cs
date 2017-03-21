using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class DetalleMantenimiento : ContentPage
	{
		Usuario usuario;
		public DetalleMantenimiento()
		{
			InitializeComponent();
		}

		public DetalleMantenimiento(Usuario user) {
			InitializeComponent();
			usuario = user;
		}

		public DetalleMantenimiento(Object incidencia, Usuario user)
		{
			InitializeComponent();
			usuario = user;
			MantenimientoIncidencia mi = (MantenimientoIncidencia)incidencia;
			for (int i = 0; i < user.incidencia; i++)
			{
				if (user.incidencias[i].Nombre == mi.Nombre)
				{
					mi = user.incidencias[i];
				}
			}
			LabelHabitacion.Text = "Habitación: "+mi.Nombre;
			LabelDetalle.Text = mi.Detalle;
			LabelObservaciones.Text = mi.Observaciones;
			LabelEncargado.Text = mi.Encargado;
		}
	}
}
