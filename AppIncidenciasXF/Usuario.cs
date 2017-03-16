using System;
namespace AppIncidenciasXF
{
	public class Usuario
	{
		public int habitacion = 0;
		public Usuario()
		{
			habitaciones = new HabitacionIncidencia[100];
		}
		public string Nick { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Type { get; set; }

		public string PhoneNumber { get; set; }

		public HabitacionIncidencia[] habitaciones { get; }

		public void addHabitacionIncidencia(HabitacionIncidencia h)
		{
			habitaciones[habitacion] = h;
			habitacion++;
		}


		public override string ToString()
		{
			return Name;
		}
	}
}
