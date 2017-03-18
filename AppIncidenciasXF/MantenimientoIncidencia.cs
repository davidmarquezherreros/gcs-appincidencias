using System;
namespace AppIncidenciasXF
{
	public class MantenimientoIncidencia
	{
		// Esta clase contiene los datos de las incidencias de mantenimiento
		public MantenimientoIncidencia()
		{
		}

		public string Nombre { get; set; }

		public string Detalle { get; set; }

		public string Horario { get; set; }

		public string Observaciones { get; set; }

		public string Encargado { get; set; }

		public override string ToString()
		{
			return string.Format("[HabitacionIncidencia: Nombre={0}, Detalle={1}, Horario={2}, Observaciones={3} Encargado={4}]", Nombre, Detalle, Horario, Observaciones, Encargado);
		}
	}
}
