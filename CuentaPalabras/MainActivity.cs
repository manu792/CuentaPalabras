using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace CuentaPalabras
{
    [Activity(Label = "Cuenta Palabras", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private EditText _parrafo;
        private Button _btnCalcular;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            EncontrarVistas();
            ConfigurarEventos();
        }

        private void EncontrarVistas()
        {
            _parrafo = FindViewById<EditText>(Resource.Id.txtParrafo);
            _btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);
        }

        private void ConfigurarEventos()
        {
            _btnCalcular.Click += _btnCalcular_Click;
        }

        private void _btnCalcular_Click(object sender, System.EventArgs e)
        {
            var activity = new Intent(this, typeof(ResultadoActivity));
            activity.PutExtra("Parrafo", _parrafo.Text);
            StartActivity(activity);
        }
    }
}

