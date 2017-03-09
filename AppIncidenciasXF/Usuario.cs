using System;
namespace AppIncidenciasXF
{
	public class Usuario
	{
		public Usuario()
		{
			
		}
		public string Nick { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Type { get; set; }

		public string PhoneNumber { get; set; }

		public Habitacion[] habitaciones;

		public override string ToString()
		{
			return Name;
		}
	}
}
