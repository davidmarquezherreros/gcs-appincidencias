using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppIncidencias
{
    [Activity(Label = "AppIncidencias")]
    public class InventarioLimpiezaActivity : Activity
    {
        private List<string> datos;
        private ListView lista;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Asociamos vista
            SetContentView(Resource.Layout.InventarioLimpieza);

            //Obtenemos el listView que nos interesa
            lista = FindViewById<ListView>(Resource.Id.listViewInventarioLimpieza);

            //Datos de prueba (cada fila del listView) (Próximamente se usará un CursorAdapter con la base de datos, si se desarrolla finalmente)
            datos = new List<string>();
            datos.Add("Producto A");
            datos.Add("Producto B");
            datos.Add("Producto C");
            datos.Add("Producto D");
            datos.Add("Producto E");
            datos.Add("Producto F");
            datos.Add("Producto G");
            datos.Add("Producto H");
            datos.Add("Producto I");
            datos.Add("Producto J");

            //Asociamos filas con un adapter 
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, datos);

            lista.Adapter = adapter;
        }
    }
}