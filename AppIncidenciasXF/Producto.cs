using System;
namespace AppIncidenciasXF
{
	public class Producto
	{
		public Producto()
		{
		}

		public string Nombre { get; set; }

		public int Cantidad { get; set; }

		public string Descripcion { get; set; }



		public override string ToString()
		{
			return string.Format("[Productos: Nombre={0}, Cantidad={1}], Descripcion{2}]", Nombre, Cantidad, Descripcion);
		}
	}
}
