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
    public partial class Sugerencias : Form
    {
        public Sugerencias()
        {
            InitializeComponent();
        }

        private void Sugerencias_Load(object sender, EventArgs e)
        {
            if(Lista.CRock>=Lista.CSalsa && Lista.CRock >= Lista.CRegue && Lista.CRock >= Lista.Celectro)
            {
                label2.Text = "Thunderstruck / AC/DC";
                label3.Text = "Triste Canción / El Tri";
                label4.Text = "Walk / Foo Fighters";
                label5.Text = "Te va a doler / Maelo Ruiz";
                label6.Text = "Alone / Alan Walker";
                label7.Text = "Pepas / Farruko";
                pictureBox1.Image = Properties.Resources.thunderstruck_ACDC;
                pictureBox2.Image = Properties.Resources.Triste_Canción_El_Tri;
                pictureBox3.Image = Properties.Resources.Walk__Foo_Fighters;
                pictureBox4.Image = Properties.Resources.Te_va_a_doler_Maelo_Ruiz;
                pictureBox5.Image = Properties.Resources.Alone_Alan_Walker;
                pictureBox6.Image = Properties.Resources.Pepas_Farruko;
            }
            if (Lista.CSalsa >= Lista.CRock && Lista.CSalsa >= Lista.CRegue && Lista.CSalsa >= Lista.Celectro)
            {

                label2.Text = "Periódico de ayer / Hector Lavoe";
                label3.Text = "El preso /de Fruko y Sus Tesos";
                label4.Text = "Fuego en el 23 / La Sonora Ponceña";
                label5.Text = "Yonaguni/ Bad Bunny";
                label6.Text = "Darkside / Alan Walker";
                label7.Text = "Riot / Three Days Grace";
                pictureBox1.Image = Properties.Resources.Periódico_de_ayer_Hector_Lavoe;
                pictureBox2.Image = Properties.Resources.El_preso_de_Fruko_y_Sus_Tesos;
                pictureBox3.Image = Properties.Resources.Fuego_en_el_23___La_Sonora_Ponceña;
                pictureBox4.Image = Properties.Resources.Yonaguni__Bad_Bunny;
                pictureBox5.Image = Properties.Resources.Darkside_Alan_Walker;
                pictureBox6.Image = Properties.Resources.Riot___Three_Days_Grace;
            }
            if (Lista.CRegue >= Lista.CSalsa && Lista.CRegue >= Lista.CRock && Lista.CRegue >= Lista.Celectro)
            {
                label2.Text = "Gasolina / Daddy Yankee.";
                label3.Text = "Ven Bailalo /  Angel & Khriz";
                label4.Text = "Quiero Bailar / Ivy Queen";
                label5.Text = "Nana / Ankor";
                label6.Text = "Levels / Avicci";
                label7.Text = "Sobrio / Maluma";
                pictureBox1.Image = Properties.Resources.Gasolina__Daddy_Yankee;
                pictureBox2.Image = Properties.Resources.Ven_Bailalo_Angel___Khriz;
                pictureBox3.Image = Properties.Resources.Quiero_Bailar_Ivy_Queen;
                pictureBox4.Image = Properties.Resources.Nana___Ankor;
                pictureBox5.Image = Properties.Resources.Levels___Avicci;
                pictureBox6.Image = Properties.Resources.Sobrio___Maluma;
            }
            if (Lista.Celectro >= Lista.CSalsa && Lista.Celectro >= Lista.CRegue && Lista.Celectro >= Lista.CRock)
            {
                label2.Text = "Danzer / Original MixDarius Syrossian";
                label3.Text = "NassauDJ Rocca / Rodion";
                label4.Text = "Other Side / EditMaya Jane Coles";
                label5.Text = "Mil horas / Andres Calamaro" ;
                label6.Text = "Se preparo / Ozuna";
                label7.Text = "Vivir la vida / Marc Anthony";
                pictureBox1.Image = Properties.Resources.Danzer___Original_MixDarius;
                pictureBox2.Image = Properties.Resources.NassauDJ_Rocca___Rodion;
                pictureBox3.Image = Properties.Resources.Other_Side___EditMaya_Jane_Coles;
                pictureBox4.Image = Properties.Resources.Mil_horas___Andres_Calamaro;
                pictureBox5.Image = Properties.Resources.Se_preparo___Ozuna;
                pictureBox6.Image = Properties.Resources.Vivir_la_vida___Marc_Anthony;
            }
            if (Lista.var1==null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var1);
            }
            if (Lista.var2 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var2);
            }
            if (Lista.var3 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var3);
            }
            if (Lista.var4 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var4);
            }
            if (Lista.var5 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var5);
            }
            if (Lista.var6 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var6);
            }
            if (Lista.var7 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var7);
            }
            if (Lista.var8 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var8);
            }
            if (Lista.var9 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var9);
            }
            if (Lista.var10 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var10);
            }
            if (Lista.var11 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var11);
            }
            if (Lista.var12 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var12);
            }
            if (Lista.var13 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var13);
            }
            if (Lista.var14 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var14);
            }
            if (Lista.var15 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var15);
            }
            if (Lista.var16 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var16);
            }
            if (Lista.var17 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var17);
            }
            if (Lista.var18 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var18);
            }
            if (Lista.var19 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var19);
            }
            if (Lista.var20 == null)
            {

            }
            else
            {
                listBox1.Items.Add(Lista.var20);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal.ActiveForm.Visible = false;
            Principal SU = new Principal();
            SU.Show();
        }
    }
}
