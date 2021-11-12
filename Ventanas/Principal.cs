using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Reproductor
{
    public partial class Principal : Form
    {
       
        public Principal()
        {
            InitializeComponent();
            DiseñodepreDeterminado();
        }
        private void DiseñodepreDeterminado()
        {
        
            PanelListaSubmenu.Visible = true;
            PanelListaSubmenu.Width = 50;
            PanelUni.Width = 50;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void OcultarsubsMenus()
        {
            
            if (PanelListaSubmenu.Visible == false)
            {
                PanelListaSubmenu.Visible = true;
            }
           
        }
     
        private void Media_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventanas.Paneles.Música());
        }
        private void prueba_Click(object sender, EventArgs e)
        {
            Abrir_cerrarPanelSubmenu();
            AcomodarPanel();
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.PanelUni.Controls.Count > 0)
                this.PanelUni.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelUni.Controls.Add(fh);
            this.PanelUni.Tag = fh;
            fh.Show();
        }
        private void Abrir_cerrarPanelSubmenu()
        {
            if (PanelListaSubmenu.Width == 50)
            {
                PanelListaSubmenu.Width = 197;                              
            }
            else if (PanelListaSubmenu.Width == 197)
            {
                PanelListaSubmenu.Width = 50;
            }
        }
        private void AcomodarPanel()
        {
            if (PanelUni.Width == 50)
            {
                PanelUni.Width = 197;
            }
            else if (PanelUni.Width == 197)
            {
                PanelUni.Width = 50;
            }
        }

        private void btAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventanas.Paneles.Ayuda());

        }

        private void btListaReproductor_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventanas.Paneles.Lista());
        }

        private void btEcualizador_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventanas.Paneles.Ecualizador());
        }
    }
}
