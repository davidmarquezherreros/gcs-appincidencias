using System;
namespace AppIncidenciasXF
{
	public class HabitacionIncidencia
	{
		// Esta clase contiene los datos de las habitaciones a limpiar
		public HabitacionIncidencia()
		{
		}
		public string Nombre { get; set; }

		public string Horario { get; set; }

		public string Encargado { get; set; }

		public string Detalle { get; set; }

		public override string ToString()
		{
			return string.Format("[HabitacionIncidencia: Nombre={0}, Detalle={1}, Horario={2}, Encargado={3}]", Nombre, Detalle, Horario, Encargado);
		}
	}
}