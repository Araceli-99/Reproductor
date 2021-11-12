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
    public partial class Lista : Form
    {
        public static string var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11, var12, var13, var14, var15, var16, var17, var18, var19, var20;
        public static int CRock, CSalsa, CRegue, Celectro;
        private void btRecomendación_Click(object sender, EventArgs e)
        {
            int RockContador = 0;
            int SalsaContador = 0;
            int RegguetonContador = 0;
            int ElectronicaContador = 0;

            //Reggueton
            if (checkBox1.Checked == true)
            {
                var1 = checkBox1.Text;
                RegguetonContador++;
            }
            if (checkBox2.Checked == true)
            {
                var2 = checkBox2.Text;
                RegguetonContador++;
            }
            if (checkBox3.Checked == true)
            {
                var3 = checkBox3.Text;
                RegguetonContador++;
            }
            if (checkBox4.Checked == true)
            {
                var4 = checkBox4.Text;
                RegguetonContador++;
            }
            if (checkBox5.Checked == true)
            {
                var5 = checkBox5.Text;
                RegguetonContador++;
            }
            //Rock
            if (checkBox6.Checked == true)
            {
                var6 = checkBox6.Text;
                RockContador++;
            }
            if (checkBox7.Checked == true)
            {
                var7 = checkBox7.Text;
                RockContador++;
            }
            if (checkBox8.Checked == true)
            {
                var8 = checkBox8.Text;
                RockContador++;
            }
            if (checkBox9.Checked == true)
            {
                var9 = checkBox9.Text;
                RockContador++;
            }
            if (checkBox10.Checked == true)
            {
                var10 = checkBox10.Text;
                RockContador++;
            }
            //Salsa
            if (checkBox11.Checked==true)
            {
                var11=checkBox11.Text;
                SalsaContador++;
            }
            if (checkBox12.Checked == true)
            {
                var12 = checkBox12.Text;
                SalsaContador++;
            }
            if (checkBox13.Checked == true)
            {
                var13 = checkBox13.Text;
                SalsaContador++;
            }
            if (checkBox14.Checked == true)
            {
                var14 = checkBox14.Text;
                SalsaContador++;
            }
            if (checkBox15.Checked == true)
            {
                var15 = checkBox15.Text;
                SalsaContador++;
            }
            //Electronica
            if (checkBox16.Checked == true)
            {
                var16 = checkBox16.Text;
                ElectronicaContador++;
            }
            if (checkBox17.Checked == true)
            {
                var17 = checkBox17.Text;
                ElectronicaContador++;
            }
            if (checkBox18.Checked == true)
            {
                var18 = checkBox18.Text;
                ElectronicaContador++;
            }
            if (checkBox19.Checked == true)
            {
                var19 = checkBox19.Text;
                ElectronicaContador++;
            }
            if (checkBox20.Checked == true)
            {
                var10 = checkBox20.Text;
                ElectronicaContador++;
            }

            CRock = RockContador;
            CSalsa=SalsaContador;
            CRegue=RegguetonContador;
            Celectro= ElectronicaContador;

            Sugerencias.ActiveForm.Visible = false;
            Sugerencias SU = new Sugerencias();
            SU.Show();
        }

        
        public Lista()
        {
            InitializeComponent();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
