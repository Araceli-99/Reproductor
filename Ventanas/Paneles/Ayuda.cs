using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor.Ventanas.Paneles
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            Respuesta1.Text = "";
            Respuesta2.Text = "";
        }
       
        private void btAyuda_Click(object sender, EventArgs e)
        {
            Respuesta1.Text = "SERVICIO DE AYUDA:\n\n" +
                "Si no puedes encontrar unasolución en las secciones de Ayuda o Comunidad" +
                "\ny deseas ponerte en contacto con Soporte al Cliente de Leaknd  puedes enviar " +
                "\nun correo a ServicioalCliente@leaknd.com ";
            Respuesta2.Text = "";
            
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
         
        }

        private void btAcercaDe_Click(object sender, EventArgs e)
        {
            Respuesta1.Text = "ACERCA DE:\n" +

                                  "\nLeaknd\n" +

                                  "\n¿Quiénes somos?  Una empresa ideal de servicios\n" +
                                  "multimedia peruana fundada en 2021.El nombre\n" +
                                  "deriva de la terminología “goteo “una manera ligera de\n" +
                                  "escuchar la música llevándote a otro nivel.Gran\n" +
                                  "experiencia que consiste en ofrecer un servicio\n" +
                                  "gratuito básico y otro con características\n" +
                                  "adicional –como una mejor calidad de audio, libre de\n" +
                                  "publicidad y de uso ilimitado. Está disponible para\n" +
                                  "los sistemas operativos Microsoft Windows y Android.\n";

            Respuesta2.Text = "\nLEAKDROP\n" +

                                  "\nUn reproductor de música que permitirá a diversos\n" +
                                  "usuarios la reproducción de canciones que estén\n" +
                                  "almacenadas en uno o varios directorios previamente\n" +
                                  "especificados.Nos importa tu opinión para ofrecerte\n" +
                                  "una experiencia distinta de escuchar música.\n";
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
           
        }
    }
}
