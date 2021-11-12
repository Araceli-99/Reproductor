using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor.Ventanas.Clases
{
    class Canciones
    {
        private string titulo;
        private string artista;
        private string directorio;
        public Canciones siguiente;
        public Canciones anterior;

        public string Artista { get => artista; set => artista = value; }
        public string Directorio { get => directorio; set => directorio = value; }
        public string Titulo { get => titulo; set => titulo = value; }
    }
}
