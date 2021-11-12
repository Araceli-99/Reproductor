
namespace Reproductor.Ventanas.Paneles
{
    partial class Música
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Música));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.ListaMúsica = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Detener = new System.Windows.Forms.PictureBox();
            this.Siguiente = new System.Windows.Forms.PictureBox();
            this.Anterior = new System.Windows.Forms.PictureBox();
            this.Reproducir = new System.Windows.Forms.PictureBox();
            this.macTrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.mactrackMusica = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContadorDeMúsica = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Album = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproducir)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Album)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(1, -1);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(515, 192);
            this.Reproductor.TabIndex = 0;
            // 
            // ListaMúsica
            // 
            this.ListaMúsica.BackColor = System.Drawing.Color.DarkGray;
            this.ListaMúsica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaMúsica.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaMúsica.FormattingEnabled = true;
            this.ListaMúsica.ItemHeight = 20;
            this.ListaMúsica.Location = new System.Drawing.Point(13, 222);
            this.ListaMúsica.Name = "ListaMúsica";
            this.ListaMúsica.Size = new System.Drawing.Size(518, 100);
            this.ListaMúsica.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.Detener);
            this.panel1.Controls.Add(this.Siguiente);
            this.panel1.Controls.Add(this.Anterior);
            this.panel1.Controls.Add(this.Reproducir);
            this.panel1.Controls.Add(this.macTrackVolumen);
            this.panel1.Controls.Add(this.mactrackMusica);
            this.panel1.Location = new System.Drawing.Point(1, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 91);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(415, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "00:00";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Reproductor.Properties.Resources.Volumen;
            this.pictureBox6.Location = new System.Drawing.Point(323, 34);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Detener
            // 
            this.Detener.Image = global::Reproductor.Properties.Resources.DetenerP;
            this.Detener.Location = new System.Drawing.Point(260, 34);
            this.Detener.Name = "Detener";
            this.Detener.Size = new System.Drawing.Size(33, 28);
            this.Detener.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Detener.TabIndex = 5;
            this.Detener.TabStop = false;
            this.Detener.Click += new System.EventHandler(this.Detener_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Image = global::Reproductor.Properties.Resources.Siguiente;
            this.Siguiente.Location = new System.Drawing.Point(202, 34);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(30, 28);
            this.Siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Siguiente.TabIndex = 4;
            this.Siguiente.TabStop = false;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Anterior
            // 
            this.Anterior.Image = global::Reproductor.Properties.Resources.Anterior;
            this.Anterior.Location = new System.Drawing.Point(117, 34);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(32, 28);
            this.Anterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anterior.TabIndex = 3;
            this.Anterior.TabStop = false;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Reproducir
            // 
            this.Reproducir.Image = global::Reproductor.Properties.Resources.Reproducir;
            this.Reproducir.Location = new System.Drawing.Point(155, 34);
            this.Reproducir.Name = "Reproducir";
            this.Reproducir.Size = new System.Drawing.Size(35, 28);
            this.Reproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reproducir.TabIndex = 2;
            this.Reproducir.TabStop = false;
            this.Reproducir.Click += new System.EventHandler(this.Reproducir_Click);
            // 
            // macTrackVolumen
            // 
            this.macTrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.macTrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackVolumen.IndentHeight = 6;
            this.macTrackVolumen.Location = new System.Drawing.Point(385, 34);
            this.macTrackVolumen.Maximum = 100;
            this.macTrackVolumen.Minimum = 0;
            this.macTrackVolumen.Name = "macTrackVolumen";
            this.macTrackVolumen.Size = new System.Drawing.Size(79, 28);
            this.macTrackVolumen.TabIndex = 1;
            this.macTrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackVolumen.TickHeight = 4;
            this.macTrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolumen.TrackerColor = System.Drawing.Color.Gray;
            this.macTrackVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackVolumen.TrackLineColor = System.Drawing.Color.Gray;
            this.macTrackVolumen.TrackLineHeight = 3;
            this.macTrackVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackVolumen.Value = 50;
            this.macTrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackVolumen_ValueChanged);
            // 
            // mactrackMusica
            // 
            this.mactrackMusica.BackColor = System.Drawing.Color.Transparent;
            this.mactrackMusica.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mactrackMusica.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mactrackMusica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mactrackMusica.IndentHeight = 6;
            this.mactrackMusica.Location = new System.Drawing.Point(12, 3);
            this.mactrackMusica.Maximum = 100;
            this.mactrackMusica.Minimum = 0;
            this.mactrackMusica.Name = "mactrackMusica";
            this.mactrackMusica.Size = new System.Drawing.Size(397, 28);
            this.mactrackMusica.TabIndex = 0;
            this.mactrackMusica.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mactrackMusica.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mactrackMusica.TickHeight = 4;
            this.mactrackMusica.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mactrackMusica.TrackerColor = System.Drawing.Color.Gray;
            this.mactrackMusica.TrackerSize = new System.Drawing.Size(16, 16);
            this.mactrackMusica.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mactrackMusica.TrackLineHeight = 3;
            this.mactrackMusica.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mactrackMusica.Value = 0;
            this.mactrackMusica.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mactrackMusica_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(550, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(550, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "N° Canciones:";
            // 
            // ContadorDeMúsica
            // 
            this.ContadorDeMúsica.AutoSize = true;
            this.ContadorDeMúsica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorDeMúsica.ForeColor = System.Drawing.Color.White;
            this.ContadorDeMúsica.Location = new System.Drawing.Point(586, 293);
            this.ContadorDeMúsica.Name = "ContadorDeMúsica";
            this.ContadorDeMúsica.Size = new System.Drawing.Size(15, 16);
            this.ContadorDeMúsica.TabIndex = 7;
            this.ContadorDeMúsica.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btBorrar);
            this.panel2.Controls.Add(this.btAgregar);
            this.panel2.Location = new System.Drawing.Point(188, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 58);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btBorrar
            // 
            this.btBorrar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(189, 20);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(104, 24);
            this.btBorrar.TabIndex = 1;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(15, 20);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(141, 24);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar cancion";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reproductor.Properties.Resources._6f08ce865655b45e1343124cda6c653c;
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(515, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(513, -1);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(159, 206);
            this.Album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Album.TabIndex = 1;
            this.Album.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Música
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(675, 402);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ContadorDeMúsica);
            this.Controls.Add(this.ListaMúsica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Reproductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Música";
            this.Text = "Música";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproducir)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Album)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.PictureBox Album;
        private System.Windows.Forms.ListBox ListaMúsica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ContadorDeMúsica;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.PictureBox Anterior;
        private System.Windows.Forms.PictureBox Reproducir;
        private XComponent.SliderBar.MACTrackBar macTrackVolumen;
        private XComponent.SliderBar.MACTrackBar mactrackMusica;
        private System.Windows.Forms.PictureBox Siguiente;
        private System.Windows.Forms.PictureBox Detener;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}