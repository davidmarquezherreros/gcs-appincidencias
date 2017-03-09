using System;
namespace AppIncidenciasXF
{
	public class Habitacion
	{
		public Habitacion()
		{
		}
		public string Nombre { get; set; }

		public string Horario { get; set; }

		public Usuario Encargado { get; set; }
	}
}
