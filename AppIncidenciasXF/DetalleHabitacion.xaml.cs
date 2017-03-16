using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIncidenciasXF
{
	public partial class DetalleHabitacion : ContentPage
	{
		public Usuario usuario;
		public DetalleHabitacion()
		{
			InitializeComponent();
		}
		public DetalleHabitacion(Usuario user)
		{
			InitializeComponent();
			usuario = user;
		}
		public DetalleHabitacion(Object habitacion, Usuario user)
		{
			InitializeComponent();
			usuario = user;
			HabitacionIncidencia h = (HabitacionIncidencia)habitacion;
			for (int i = 0; i < user.habitacion; i++)
			{
				if (user.habitaciones[i].Nombre == h.Nombre)
				{
					h = user.habitaciones[i];
				}
			}
			LabelDetalle.Text = h.Detalle;
			LabelHorario.Text = "Horario: "+h.Horario;
			LabelEncargado.Text = h.Encargado;
		}
	}
}
