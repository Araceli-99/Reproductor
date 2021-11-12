using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace Reproductor.Ventanas.Paneles
{
    public partial class Música : Form
    {
        string directorioMP3 = "";
        bool estado = true;
        Clases.Canciones song = new Clases.Canciones();
        public Música()
        {
            InitializeComponent();
            Predeterminados();
        }
        private void Predeterminados()
        {
            tamañoYLocalización();
        }
        private void tamañoYLocalización()
        {
            Reproductor.Width = 515;
            Reproductor.Height = 220;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.FileName = "Seleccione una canción";
            abrir.Filter = "Archivo mp3|*.mp3|Archivo wav|*.wav|Archivo MP4|*.MP4|Todos los Archivos|*.*";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            abrir.FilterIndex = 1;
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                directorioMP3 = abrir.FileName;
                TagLib.File tags = TagLib.File.Create(directorioMP3);

                //Envia datos a la funcion cargar listado
                AdiccionarCanciones(tags.Tag.Title, tags.Tag.JoinedPerformers, directorioMP3);
                //Llina listbox con las canciones seleccionadas
                ListaMúsica.Items.Add(tags.Tag.Title);

                ContadorDeMúsica.Text = Convert.ToString(ListaMúsica.Items.Count);
                if (ListaMúsica.Items.Count == 1)
                {
                    song = Clases.Datos.media.Inicio;
                    Reproductor.URL = song.Directorio;
                    Reproductor.Ctlcontrols.stop();
                }
            }
        }
        public void AdiccionarCanciones(string name, string artist, string url)
        {
            Clases.Datos.media.SiguienteCanción(name, artist, url);
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            Clases.Datos.media.Eliminar();
            ListaMúsica.Items.Clear();

            ContadorDeMúsica.Text = Convert.ToString(ListaMúsica.Items.Count);
            Album.Image = Properties.Resources.Caractula;
        }

        private void Reproducir_Click(object sender, EventArgs e)
        {
            if (song == null || Reproductor.URL == "")
            {
                MessageBox.Show("No ha ingresado una canción en la lista de reproducción");
            }
            else
            {
                cargarControles();
                switch (estado)
                {
                    case true:
                        Reproductor.Ctlcontrols.play();
                       Reproducir.Image = Properties.Resources.Detener;
                        estado = false;
                        break;
                    case false:
                        Reproductor.Ctlcontrols.pause();
                        Reproducir.Image = Properties.Resources.Reproducir;
                        estado = true;
                        break;
                }
            }
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            song = song.anterior;
            if (song == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                Reproductor.URL = song.Directorio;
                
                cargarControles();
            }
        }

        private void mactrackMusica_ValueChanged(object sender, decimal value)
        {
            Reproductor.Ctlcontrols.currentPosition = mactrackMusica.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadLista()
        {
            string archivo = "";
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.FileName = "Seleccione na lista";
            abrir.Filter = "Lista de Reproduccion|*.geo";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            abrir.FilterIndex = 1;
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                archivo = abrir.FileName;
                FileStream lista = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader LeerArchivo = new StreamReader(lista);

                Reproductor.Ctlcontrols.stop();

                Clases.Datos.media.Eliminar();
                ListaMúsica.Items.Clear();
                string linea;
                while ((linea = LeerArchivo.ReadLine()) != null)
                {
                    string[] cadena = linea.Split(';');
                    int cont = 0;
                    Clases.Canciones c = new Clases.Canciones();
                    foreach (string subcadena in cadena)
                    {
                        //Lleno un objeto de tipo contacto y le asigno sus propiedades
                        if (cont == 0) { ListaMúsica.Items.Add(subcadena); c.Titulo = subcadena; }
                        if (cont == 1) { c.Directorio = subcadena; TagLib.File dt = TagLib.File.Create(subcadena); c.Artista = dt.Tag.JoinedPerformers; }
                        if (cont == 2) { label1.Text = subcadena; }
                        cont++; 
                    }
                    
                    Clases.Datos.media.SiguienteCanción(c.Titulo, c.Artista, c.Directorio);
                }

                //cierro la lectura de archivo
                LeerArchivo.Close();

                CargarLista();

                ContadorDeMúsica.Text = Convert.ToString(ListaMúsica.Items.Count);
                song = Clases.Datos.media.Inicio;
                Reproductor.URL = song.Directorio;
                Reproductor.Ctlcontrols.stop();
                cargarControles();
            }
        }
        public void TrackSlide()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
               mactrackMusica.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mactrackMusica.Value = 0;
            }
        }
        public void cargarControles()
        {
            TagLib.File dts = TagLib.File.Create(song.Directorio);
            label1.Text = dts.Tag.Title;
            label2.Text = dts.Tag.JoinedPerformers;

            if (dts.Tag.Pictures.Length >= 1)
            {

                MemoryStream pic = new MemoryStream(dts.Tag.Pictures[0].Data.Data);
                Album.Image = Image.FromStream(pic);
            }
            else
            {
                 Album.Image = Properties.Resources.Caractula;
            }
        }

        public void CargarLista()
        {
            string lt = "";
            string nombrearchivo = "Listas.txt";
            System.IO.FileStream archivo = new System.IO.FileStream(nombrearchivo, FileMode.OpenOrCreate, FileAccess.Read);
            System.IO.StreamReader LeerArchivo = new System.IO.StreamReader(archivo);

            string linea;
            while ((linea = LeerArchivo.ReadLine()) != null)
            {
                string[] cadena = linea.Split(';');
                int cont = 0;
                foreach (string subcadena in cadena)
                {
                    //Lleno un objeto de tipo contacto y le asigno sus propiedades
                    if (cont == 0) { lt = subcadena; }
                    if (cont == 1 && label1.Text == lt) { Album.Image = Image.FromFile(subcadena); }
                    cont++; //aumento el contador para la ubicación de columnas
                }
            }
            //cierro la lectura de archivo
            LeerArchivo.Close();
        }
        public void GuardarLista()
        {
            FileStream archivo = new FileStream("Listas.txt", FileMode.Append, FileAccess.Write);
            StreamWriter Escribir = new StreamWriter(archivo);

            Escribir.WriteLine(Clases.Datos.nombre + ";" + Clases.Datos.imagen);
            Escribir.Close();
        }
        public void GuardaText(string name)
        {
            FileStream archivo = new FileStream(name + ".geo", FileMode.Append, FileAccess.Write);
            StreamWriter Escribir = new StreamWriter(archivo);
            String[] matriz = new String[ListaMúsica.Items.Count];
            for (int i = 0; i < ListaMúsica.Items.Count; i++)
            {
                matriz[i] = ListaMúsica.Items[i].ToString();
                Escribir.WriteLine(matriz[i] + ";" + Clases.Datos.media.EmcontrarCanción(matriz[i]) + ";" + Clases.Datos.nombre);
            }
            Escribir.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TrackSlide();
            mactrackMusica.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            double t = Math.Floor(0 + Reproductor.Ctlcontrols.currentPosition);
            label4.Text = t.ToString();
            //double t2 = Math.Floor(Reproductor.currentMedia.duration);
            //label3.Text = t2.ToString();
        }

        private void macTrackVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = macTrackVolumen.Value;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Reproductor.settings.mute = true;
            macTrackVolumen.Value = 0;
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            song = song.anterior;
            if (song == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                Reproductor.URL = song.Directorio;
                cargarControles();
            }
        }

        private void Detener_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
        }
    }
}
