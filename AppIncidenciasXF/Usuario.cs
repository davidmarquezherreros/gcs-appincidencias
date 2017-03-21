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
			// Creamos las habitaciones de la residencia
			habitacionesDisponibles = new Habitacion[10];
			habitacionesDisponibles[0] = new Habitacion { Nombre = "Habitacion 1", Ubicacion = "Planta 0 - Puerta 1", Tamanyo = "20", Situacion = "Ocupada" , Tipo="Individual"};
			habitacionesDisponibles[1] = new Habitacion { Nombre = "Habitacion 2", Ubicacion = "Planta 0 - Puerta 2", Tamanyo = "20", Situacion = "Ocupada", Tipo = "Individual" };
			habitacionesDisponibles[2] = new Habitacion { Nombre = "Habitacion 3", Ubicacion = "Planta 1 - Puerta 1", Tamanyo = "20", Situacion = "Libre", Tipo = "Doble" };
			habitacionesDisponibles[3] = new Habitacion { Nombre = "Habitacion 4", Ubicacion = "Planta 1 - Puerta 2", Tamanyo = "20", Situacion = "Ocupada", Tipo = "Triple" };
			habitacionesDisponibles[4] = new Habitacion { Nombre = "Habitacion 5", Ubicacion = "Planta 2 - Puerta 1", Tamanyo = "20", Situacion = "Libre", Tipo = "Doble" };
			habitacionesDisponibles[5] = new Habitacion { Nombre = "Habitacion 6", Ubicacion = "Planta 2 - Puerta 2", Tamanyo = "20", Situacion = "Ocupada", Tipo = "Individual" };
			habitacionesDisponibles[6] = new Habitacion { Nombre = "Habitacion 7", Ubicacion = "Planta 3 - Puerta 1", Tamanyo = "20", Situacion = "Libre", Tipo = "Doble" };
			habitacionesDisponibles[7] = new Habitacion { Nombre = "Habitacion 8", Ubicacion = "Planta 3 - Puerta 2", Tamanyo = "20", Situacion = "Ocupada", Tipo = "Individual" };
			habitacionesDisponibles[8] = new Habitacion { Nombre = "Habitacion 9", Ubicacion = "Planta 4 - Puerta 1", Tamanyo = "20", Situacion = "Libre", Tipo = "Individual" };
			habitacionesDisponibles[9] = new Habitacion { Nombre = "Habitacion 10", Ubicacion = "Planta 4 - Puerta 2", Tamanyo = "20", Situacion = "Ocupada", Tipo = "Triple" };

		}
		public string Nick { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Type { get; set; }

		public string PhoneNumber { get; set; }

		public Boolean Logueado { get; set; }

		public Habitacion[] habitacionesDisponibles { get; }

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
