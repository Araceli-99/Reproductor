
namespace Reproductor.Ventanas.Paneles
{
    partial class Ayuda
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
            this.Respuesta1 = new System.Windows.Forms.Label();
            this.Respuesta2 = new System.Windows.Forms.Label();
            this.btAyuda = new System.Windows.Forms.Button();
            this.btAcercaDe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Respuesta1
            // 
            this.Respuesta1.AutoSize = true;
            this.Respuesta1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta1.ForeColor = System.Drawing.Color.White;
            this.Respuesta1.Location = new System.Drawing.Point(46, 98);
            this.Respuesta1.Name = "Respuesta1";
            this.Respuesta1.Size = new System.Drawing.Size(65, 22);
            this.Respuesta1.TabIndex = 1;
            this.Respuesta1.Text = "label1";
            // 
            // Respuesta2
            // 
            this.Respuesta2.AutoSize = true;
            this.Respuesta2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta2.ForeColor = System.Drawing.Color.White;
            this.Respuesta2.Location = new System.Drawing.Point(370, 131);
            this.Respuesta2.Name = "Respuesta2";
            this.Respuesta2.Size = new System.Drawing.Size(65, 22);
            this.Respuesta2.TabIndex = 2;
            this.Respuesta2.Text = "label1";
            // 
            // btAyuda
            // 
            this.btAyuda.BackColor = System.Drawing.Color.Gray;
            this.btAyuda.FlatAppearance.BorderSize = 0;
            this.btAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAyuda.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAyuda.ForeColor = System.Drawing.Color.White;
            this.btAyuda.Location = new System.Drawing.Point(374, 25);
            this.btAyuda.Name = "btAyuda";
            this.btAyuda.Size = new System.Drawing.Size(193, 35);
            this.btAyuda.TabIndex = 0;
            this.btAyuda.Text = "Ayuda";
            this.btAyuda.UseVisualStyleBackColor = false;
            this.btAyuda.Click += new System.EventHandler(this.btAyuda_Click);
            // 
            // btAcercaDe
            // 
            this.btAcercaDe.BackColor = System.Drawing.Color.Gray;
            this.btAcercaDe.FlatAppearance.BorderSize = 0;
            this.btAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcercaDe.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcercaDe.ForeColor = System.Drawing.Color.White;
            this.btAcercaDe.Location = new System.Drawing.Point(50, 25);
            this.btAcercaDe.Name = "btAcercaDe";
            this.btAcercaDe.Size = new System.Drawing.Size(193, 35);
            this.btAcercaDe.TabIndex = 1;
            this.btAcercaDe.Text = "Acerca de";
            this.btAcercaDe.UseVisualStyleBackColor = false;
            this.btAcercaDe.Click += new System.EventHandler(this.btAcercaDe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.btAcercaDe);
            this.panel1.Controls.Add(this.btAyuda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 100);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reproductor.Properties.Resources.logo_general__1_;
            this.pictureBox2.Location = new System.Drawing.Point(59, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reproductor.Properties.Resources.Nombre_de_la_App;
            this.pictureBox1.Location = new System.Drawing.Point(348, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(639, 456);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Respuesta2);
            this.Controls.Add(this.Respuesta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Respuesta1;
        private System.Windows.Forms.Label Respuesta2;
        private System.Windows.Forms.Button btAyuda;
        private System.Windows.Forms.Button btAcercaDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}