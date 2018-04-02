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

namespace CuentaPalabras.Logica
{
    public class Letras
    {
        public int ContarVocales(string parrafo)
        {
            int vocales = 0;
            var arreglo = parrafo.ToLower().ToCharArray();

            foreach(var letra in arreglo)
                switch (letra)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vocales++;
                        break;
                }

            return vocales;
        }

        public int ContarConsonantes(string parrafo)
        {
            int consonantes = 0;
            var arreglo = parrafo.ToLower().ToCharArray();

            foreach (var letra in arreglo)
                switch (letra)
                {
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'ñ':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        consonantes++;
                        break;
                }

            return consonantes;
        }

        public int ContarPalabras(string parrafo)
        {
            var arreglo = parrafo.Split(' ');
            var palabras = arreglo.Where(c => c != string.Empty);
            return palabras.Count();
        }
    }
}