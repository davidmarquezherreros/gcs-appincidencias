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
		}
		public DetalleHabitacion(Object habitacion, Usuario user)
		{
			InitializeComponent();
			HabitacionIncidencia h = (HabitacionIncidencia)habitacion;
			LabelDetalle.Text = h.Detalle;
			LabelHorario.Text = "Horario: "+h.Horario;
			LabelEncargado.Text = h.Encargado;
		}
	}
}
