using System;
namespace AppIncidenciasXF
{
	public class Habitacion
	{
		// Esta clase contiene los datos de las habitaciones a limpiar
		public Habitacion()
		{
		}
		public string Nombre { get; set; }

		public string Horario { get; set; }

		public string Encargado { get; set; }

		public override string ToString()
		{
			return string.Format("[Habitacion: Nombre={0}, Horario={1}, Encargado={2}]", Nombre, Horario, Encargado);
		}
	}
}