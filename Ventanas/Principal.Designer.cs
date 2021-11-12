
namespace Reproductor
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelListaSubmenu = new System.Windows.Forms.Panel();
            this.PanelIcono = new System.Windows.Forms.Panel();
            this.PanelUni = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAyuda = new System.Windows.Forms.Button();
            this.btEcualizador = new System.Windows.Forms.Button();
            this.btListaReproductor = new System.Windows.Forms.Button();
            this.Media = new System.Windows.Forms.Button();
            this.btSubMenu = new System.Windows.Forms.Button();
            this.PanelListaSubmenu.SuspendLayout();
            this.PanelIcono.SuspendLayout();
            this.PanelUni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelListaSubmenu
            // 
            this.PanelListaSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.PanelListaSubmenu.Controls.Add(this.btAyuda);
            this.PanelListaSubmenu.Controls.Add(this.btEcualizador);
            this.PanelListaSubmenu.Controls.Add(this.btListaReproductor);
            this.PanelListaSubmenu.Controls.Add(this.Media);
            this.PanelListaSubmenu.Controls.Add(this.PanelIcono);
            this.PanelListaSubmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelListaSubmenu.Location = new System.Drawing.Point(0, 0);
            this.PanelListaSubmenu.Name = "PanelListaSubmenu";
            this.PanelListaSubmenu.Size = new System.Drawing.Size(197, 672);
            this.PanelListaSubmenu.TabIndex = 0;
            // 
            // PanelIcono
            // 
            this.PanelIcono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.PanelIcono.Controls.Add(this.btSubMenu);
            this.PanelIcono.Location = new System.Drawing.Point(0, 3);
            this.PanelIcono.Name = "PanelIcono";
            this.PanelIcono.Size = new System.Drawing.Size(197, 80);
            this.PanelIcono.TabIndex = 0;
            // 
            // PanelUni
            // 
            this.PanelUni.BackColor = System.Drawing.Color.Black;
            this.PanelUni.Controls.Add(this.pictureBox1);
            this.PanelUni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUni.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelUni.Location = new System.Drawing.Point(197, 0);
            this.PanelUni.Name = "PanelUni";
            this.PanelUni.Size = new System.Drawing.Size(952, 672);
            this.PanelUni.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Reproductor.Properties.Resources.imagen_base_el_proyecto__1_;
            this.pictureBox1.Location = new System.Drawing.Point(400, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btAyuda
            // 
            this.btAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAyuda.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAyuda.ForeColor = System.Drawing.Color.Transparent;
            this.btAyuda.Image = global::Reproductor.Properties.Resources.ayuda__;
            this.btAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAyuda.Location = new System.Drawing.Point(3, 434);
            this.btAyuda.Name = "btAyuda";
            this.btAyuda.Size = new System.Drawing.Size(196, 52);
            this.btAyuda.TabIndex = 5;
            this.btAyuda.Text = "Ayuda";
            this.btAyuda.UseVisualStyleBackColor = false;
            this.btAyuda.Click += new System.EventHandler(this.btAyuda_Click);
            // 
            // btEcualizador
            // 
            this.btEcualizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btEcualizador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEcualizador.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEcualizador.ForeColor = System.Drawing.Color.Transparent;
            this.btEcualizador.Image = global::Reproductor.Properties.Resources.ecua__2__1_;
            this.btEcualizador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEcualizador.Location = new System.Drawing.Point(3, 319);
            this.btEcualizador.Name = "btEcualizador";
            this.btEcualizador.Size = new System.Drawing.Size(196, 52);
            this.btEcualizador.TabIndex = 4;
            this.btEcualizador.Text = "Ecualizador";
            this.btEcualizador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEcualizador.UseVisualStyleBackColor = false;
            this.btEcualizador.Click += new System.EventHandler(this.btEcualizador_Click);
            // 
            // btListaReproductor
            // 
            this.btListaReproductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btListaReproductor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btListaReproductor.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListaReproductor.ForeColor = System.Drawing.Color.Transparent;
            this.btListaReproductor.Image = global::Reproductor.Properties.Resources.Lista_reproducción_;
            this.btListaReproductor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btListaReproductor.Location = new System.Drawing.Point(3, 207);
            this.btListaReproductor.Name = "btListaReproductor";
            this.btListaReproductor.Size = new System.Drawing.Size(196, 52);
            this.btListaReproductor.TabIndex = 3;
            this.btListaReproductor.Text = "Listas";
            this.btListaReproductor.UseVisualStyleBackColor = false;
            this.btListaReproductor.Click += new System.EventHandler(this.btListaReproductor_Click);
            // 
            // Media
            // 
            this.Media.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Media.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Media.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Media.ForeColor = System.Drawing.Color.Transparent;
            this.Media.Image = global::Reproductor.Properties.Resources.Media_;
            this.Media.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Media.Location = new System.Drawing.Point(1, 109);
            this.Media.Name = "Media";
            this.Media.Size = new System.Drawing.Size(196, 47);
            this.Media.TabIndex = 2;
            this.Media.Text = "Media";
            this.Media.UseVisualStyleBackColor = false;
            this.Media.Click += new System.EventHandler(this.Media_Click);
            // 
            // btSubMenu
            // 
            this.btSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btSubMenu.FlatAppearance.BorderSize = 0;
            this.btSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubMenu.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubMenu.ForeColor = System.Drawing.Color.White;
            this.btSubMenu.Image = global::Reproductor.Properties.Resources.Menú_barra_lateral__1_;
            this.btSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSubMenu.Location = new System.Drawing.Point(1, -3);
            this.btSubMenu.Name = "btSubMenu";
            this.btSubMenu.Size = new System.Drawing.Size(196, 47);
            this.btSubMenu.TabIndex = 0;
            this.btSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSubMenu.UseVisualStyleBackColor = false;
            this.btSubMenu.Click += new System.EventHandler(this.prueba_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1149, 672);
            this.Controls.Add(this.PanelUni);
            this.Controls.Add(this.PanelListaSubmenu);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelListaSubmenu.ResumeLayout(false);
            this.PanelIcono.ResumeLayout(false);
            this.PanelUni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelListaSubmenu;
        private System.Windows.Forms.Button Media;
        private System.Windows.Forms.Panel PanelIcono;
        private System.Windows.Forms.Button btSubMenu;
        private System.Windows.Forms.Panel PanelUni;
        private System.Windows.Forms.Button btAyuda;
        private System.Windows.Forms.Button btEcualizador;
        private System.Windows.Forms.Button btListaReproductor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

