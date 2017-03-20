using System;
namespace AppIncidenciasXF
{
	public class Usuario
	{
		public int habitacion = 0;
		public int incidencia = 0;
		public int pro = 0;
		public int proLimpieza = 0;
		public Usuario()
		{
			habitaciones = new HabitacionIncidencia[100];
			incidencias = new MantenimientoIncidencia[100];
			productos = new Producto[100];
			productosLimpieza = new Producto[100];
		}
		public string Nick { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Type { get; set; }

		public string PhoneNumber { get; set; }

		public Boolean Logueado { get; set; }

		public HabitacionIncidencia[] habitaciones { get; }

		public MantenimientoIncidencia[] incidencias { get; }
		public Producto[] productos { get; }
		public Producto[] productosLimpieza { get; }

		public void addHabitacionIncidencia(HabitacionIncidencia h)
		{
			habitaciones[habitacion] = h;
			habitacion++;
		}

		public void addMantenimientoIncidencia(MantenimientoIncidencia mi)
		{
			incidencias[incidencia] = mi;
			incidencia++;
		}
		public void addProductos(Producto p) {

			productos[pro] = p;
			pro++;
		}
		public void addProductosLimpieza(Producto p)
		{

			productosLimpieza[proLimpieza] = p;
			proLimpieza++;
		}


		public override string ToString()
		{
			return Name;
		}
	}
}
