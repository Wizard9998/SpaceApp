
namespace SpaceApp.Forms
{
    partial class Fase1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fase1));
            this.lbPregunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdbRespuesta1 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta2 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta3 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPregunta
            // 
            this.lbPregunta.AutoSize = true;
            this.lbPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lbPregunta.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbPregunta.ForeColor = System.Drawing.Color.White;
            this.lbPregunta.Location = new System.Drawing.Point(54, 41);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(251, 29);
            this.lbPregunta.TabIndex = 5;
            this.lbPregunta.Text = "¿Qué es un motor Warp?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(443, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(346, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // rdbRespuesta1
            // 
            this.rdbRespuesta1.AutoSize = true;
            this.rdbRespuesta1.BackColor = System.Drawing.Color.Transparent;
            this.rdbRespuesta1.BackgroundImage = global::SpaceApp.Properties.Resources.Boton_vacio;
            this.rdbRespuesta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbRespuesta1.ForeColor = System.Drawing.Color.Black;
            this.rdbRespuesta1.Location = new System.Drawing.Point(54, 159);
            this.rdbRespuesta1.Name = "rdbRespuesta1";
            this.rdbRespuesta1.Size = new System.Drawing.Size(117, 19);
            this.rdbRespuesta1.TabIndex = 10;
            this.rdbRespuesta1.TabStop = true;
            this.rdbRespuesta1.Text = "Motor Hipotetico";
            this.rdbRespuesta1.UseVisualStyleBackColor = false;
            this.rdbRespuesta1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbRespuesta2
            // 
            this.rdbRespuesta2.AutoSize = true;
            this.rdbRespuesta2.BackColor = System.Drawing.Color.Transparent;
            this.rdbRespuesta2.BackgroundImage = global::SpaceApp.Properties.Resources.Boton_vacio;
            this.rdbRespuesta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbRespuesta2.Location = new System.Drawing.Point(54, 252);
            this.rdbRespuesta2.Name = "rdbRespuesta2";
            this.rdbRespuesta2.Size = new System.Drawing.Size(106, 19);
            this.rdbRespuesta2.TabIndex = 11;
            this.rdbRespuesta2.TabStop = true;
            this.rdbRespuesta2.Text = "Motor Electrico";
            this.rdbRespuesta2.UseVisualStyleBackColor = false;
            // 
            // rdbRespuesta3
            // 
            this.rdbRespuesta3.AutoSize = true;
            this.rdbRespuesta3.BackColor = System.Drawing.Color.Transparent;
            this.rdbRespuesta3.BackgroundImage = global::SpaceApp.Properties.Resources.Boton_vacio;
            this.rdbRespuesta3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbRespuesta3.Location = new System.Drawing.Point(186, 159);
            this.rdbRespuesta3.Name = "rdbRespuesta3";
            this.rdbRespuesta3.Size = new System.Drawing.Size(101, 19);
            this.rdbRespuesta3.TabIndex = 12;
            this.rdbRespuesta3.TabStop = true;
            this.rdbRespuesta3.Text = "Motor Hibrido";
            this.rdbRespuesta3.UseVisualStyleBackColor = false;
            // 
            // rdbRespuesta4
            // 
            this.rdbRespuesta4.AutoSize = true;
            this.rdbRespuesta4.BackColor = System.Drawing.Color.Transparent;
            this.rdbRespuesta4.BackgroundImage = global::SpaceApp.Properties.Resources.Boton_vacio;
            this.rdbRespuesta4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbRespuesta4.Location = new System.Drawing.Point(186, 252);
            this.rdbRespuesta4.Name = "rdbRespuesta4";
            this.rdbRespuesta4.Size = new System.Drawing.Size(112, 19);
            this.rdbRespuesta4.TabIndex = 13;
            this.rdbRespuesta4.TabStop = true;
            this.rdbRespuesta4.Text = "Motor de Fusion";
            this.rdbRespuesta4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbRespuesta4);
            this.Controls.Add(this.rdbRespuesta3);
            this.Controls.Add(this.rdbRespuesta2);
            this.Controls.Add(this.rdbRespuesta1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPregunta);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Fase1";
            this.Text = "Fase1";
            this.Load += new System.EventHandler(this.Fase1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdbRespuesta1;
        private System.Windows.Forms.RadioButton rdbRespuesta2;
        private System.Windows.Forms.RadioButton rdbRespuesta3;
        private System.Windows.Forms.RadioButton rdbRespuesta4;
        private System.Windows.Forms.Button button1;
    }
}