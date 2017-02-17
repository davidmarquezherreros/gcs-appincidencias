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
    public class LimpiezaActivity : Activity
    {
        private List<string> datos;
        private ListView lista;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Asociamos vista
            SetContentView(Resource.Layout.Limpieza);

            //Obtenemos el listView que nos interesa
            lista = FindViewById<ListView>(Resource.Id.listViewLimpieza);

            //Datos de prueba (cada fila del listView) (Pr�ximamente se usar� un CursorAdapter con la base de datos, si se desarrolla finalmente)
            datos = new List<string>();
            datos.Add("Habitaci�n 1");
            datos.Add("Habitaci�n 2");
            datos.Add("Habitaci�n 3");
            datos.Add("Habitaci�n 4");
            datos.Add("Habitaci�n 5");
            datos.Add("Habitaci�n 6");
            datos.Add("Habitaci�n 7");
            datos.Add("Habitaci�n 8");
            datos.Add("Habitaci�n 9");
            datos.Add("Habitaci�n 10");

            //Asociamos filas con un adapter 
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, datos);

            lista.Adapter = adapter; 
        }
    }
}