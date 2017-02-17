using Android.App;
using Android.Widget;
using Android.OS;

namespace AppIncidencias
{
    [Activity(Label = "AppIncidencias", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Cargar una vista
            SetContentView (Resource.Layout.Registro);

            //Cargar una actividad que a su vez cargará su propia vista
            //StartActivity(typeof(InventarioLimpiezaActivity));
        }
    }
}
