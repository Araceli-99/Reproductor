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
    public partial class Ecualizador : Form
    {
        public Ecualizador()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

     

        private void macTrackBar3_ValueChanged_1(object sender, decimal value)
        {
            axWindowsMediaPlayer1.settings.volume = macTrackBar3.Value;
        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            axWindowsMediaPlayer1.settings.volume = macTrackBar1.Value;
        }

        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            axWindowsMediaPlayer1.settings.volume = macTrackBar2.Value;
        }
    }
}
