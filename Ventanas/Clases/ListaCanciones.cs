using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor.Ventanas.Clases
{
    class ListaCanciones
    {
        private Canciones inicio;
        public Canciones Inicio
        {
            get { return inicio; }
        }
        public ListaCanciones()
        {
            inicio = null;
        }
        private void PrimeraCanción(string nombre, string artista, string directorio) //Se crea la Primera persona que se ingresa
        {
            Canciones nuevo = new Canciones();
            nuevo.Titulo = nombre;
            nuevo.Artista = artista;
            nuevo.Directorio = directorio;

            nuevo.siguiente = nuevo;  
            nuevo.anterior = nuevo;
            inicio = nuevo;
        }

        public void SiguienteCanción(string nombre, string artista, string directorio) 
        {
            if (inicio == null)
            {
                PrimeraCanción(nombre, artista, directorio); 
            }
            else
            {
                Canciones nuevo = new Canciones();
                nuevo.Titulo = nombre;
                nuevo.Artista = artista;
                nuevo.Directorio = directorio;

                Canciones temp = new Canciones();
                temp = inicio.anterior;
                nuevo.siguiente = inicio;
                nuevo.anterior = temp;
                inicio.anterior = nuevo;
                temp.siguiente = nuevo;
            }
        }

        public string EmcontrarCanción(string title) 
        {
            Canciones temporal = new Canciones();    
            temporal = inicio;
            while (temporal != null) 
            {
                if (temporal.Titulo == title)
                {
                    return temporal.Directorio;  
                }
                else
                {
                    temporal = temporal.siguiente; 
                }
            }
            return null;
        }

        public string BuscarCanción(string title)  
        {
            Canciones temporal = new Canciones();   
            temporal = inicio;
            while (temporal != null)
            {
                if (temporal.Titulo.Equals(title))
                {
                    return temporal.Directorio;  
                }
                else
                {
                    temporal = temporal.siguiente; 
                }
            }
            return null;
        }

        public void Eliminar() 
        {
            Canciones actual = new Canciones();   
            Canciones temp = new Canciones();
            actual = inicio;
            while (actual != null) 
            {
                inicio = null;
                temp = actual.siguiente;
                actual = null;
            }
        }
    }
}
