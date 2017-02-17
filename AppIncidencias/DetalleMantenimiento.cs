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
    [Activity(Label = "DetalleMantenimiento")]
    public class DetalleMantenimiento : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Asociamos vista
            SetContentView(Resource.Layout.DetalleMantenimiento);
        }
    }
}