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
			LabelHorario.Text = "Horario: "+h.Horario;
			LabelEncargado.Text = h.Encargado;
			Habitacion habitacionauxiliar = new Habitacion();
			foreach (Habitacion hab in user.habitacionesDisponibles) {
				if (hab.Nombre == h.Nombre)
				{
					habitacionauxiliar = hab;
				}
			}
			LabelTipo.Text = "Tipo: " + habitacionauxiliar.Tipo;
			LabelTamaño.Text = "Tamaño: "+habitacionauxiliar.Tamanyo+"m\u00B2";
			LabelSituacion.Text = "Situacion: "+habitacionauxiliar.Situacion;
			LabelUbicacion.Text = "Ubicacion: "+habitacionauxiliar.Ubicacion;
		}
	}
}
