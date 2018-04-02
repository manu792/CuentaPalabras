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
using CuentaPalabras.Logica;

namespace CuentaPalabras
{
    [Activity(Label = "Resultado")]
    public class ResultadoActivity : Activity
    {
        private EditText _vocales;
        private EditText _consonantes;
        private EditText _palabras;
        private Letras _letras;
        private string _parrafo;

        public ResultadoActivity()
        {
            _letras = new Letras();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Obtiene el parrafo de la primer actividad
            _parrafo = Intent.GetStringExtra("Parrafo");

            // Create your application here
            SetContentView(Resource.Layout.Resultado);
            EncontrarVistas();
        }

        private void EncontrarVistas()
        {
            _vocales = FindViewById<EditText>(Resource.Id.txtVocales);
            _consonantes = FindViewById<EditText>(Resource.Id.txtConsonantes);
            _palabras = FindViewById<EditText>(Resource.Id.txtPalabras);

            // Asigno cantidades a sus respectivos controles
            _vocales.Text = _letras.ContarVocales(_parrafo).ToString();
            _consonantes.Text = _letras.ContarConsonantes(_parrafo).ToString();
            _palabras.Text = _letras.ContarPalabras(_parrafo).ToString();
        }
    }
}