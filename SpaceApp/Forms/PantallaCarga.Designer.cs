
namespace SpaceApp.Forms
{
    partial class PantallaCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCarga));
            this.lblDato = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNoAcepto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Font = new System.Drawing.Font("standard 07_53", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDato.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDato.Image = global::SpaceApp.Properties.Resources.Austronauta_fondo;
            this.lblDato.Location = new System.Drawing.Point(329, 26);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(348, 270);
            this.lblDato.TabIndex = 0;
            this.lblDato.Text = resources.GetString("lblDato.Text");
            this.lblDato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDato.Click += new System.EventHandler(this.lblDato_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SpaceApp.Properties.Resources.Austronauta;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::SpaceApp.Properties.Resources.Boton_vacio;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Location = new System.Drawing.Point(507, 317);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnNoAcepto
            // 
            this.btnNoAcepto.BackgroundImage = global::SpaceApp.Properties.Resources.Boton_vacio;
            this.btnNoAcepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoAcepto.Location = new System.Drawing.Point(405, 317);
            this.btnNoAcepto.Name = "btnNoAcepto";
            this.btnNoAcepto.Size = new System.Drawing.Size(75, 23);
            this.btnNoAcepto.TabIndex = 4;
            this.btnNoAcepto.Text = "No acepto";
            this.btnNoAcepto.UseVisualStyleBackColor = true;
            this.btnNoAcepto.Click += new System.EventHandler(this.btnNoAcepto_Click);
            // 
            // PantallaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceApp.Properties.Resources.Austronauta_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 352);
            this.Controls.Add(this.btnNoAcepto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDato);
            this.Name = "PantallaCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Carga(DEMO)";
            this.Load += new System.EventHandler(this.PantallaCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNoAcepto;
    }
}