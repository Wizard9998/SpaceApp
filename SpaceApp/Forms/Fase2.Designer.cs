
namespace SpaceApp.Forms
{
    partial class Fase2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fase2));
            this.labPregunta = new System.Windows.Forms.Label();
            this.btnCorrecto = new System.Windows.Forms.Button();
            this.btnIncorrecto = new System.Windows.Forms.Button();
            this.btnIncorrecto3 = new System.Windows.Forms.Button();
            this.btnIncorecto2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labPregunta
            // 
            this.labPregunta.AutoSize = true;
            this.labPregunta.Location = new System.Drawing.Point(228, 83);
            this.labPregunta.Name = "labPregunta";
            this.labPregunta.Size = new System.Drawing.Size(38, 15);
            this.labPregunta.TabIndex = 0;
            this.labPregunta.Text = "label1";
            // 
            // btnCorrecto
            // 
            this.btnCorrecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrecto.BackgroundImage")));
            this.btnCorrecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrecto.Location = new System.Drawing.Point(80, 239);
            this.btnCorrecto.Name = "btnCorrecto";
            this.btnCorrecto.Size = new System.Drawing.Size(118, 31);
            this.btnCorrecto.TabIndex = 10;
            this.btnCorrecto.Text = "Siguiente";
            this.btnCorrecto.UseVisualStyleBackColor = true;
            // 
            // btnIncorrecto
            // 
            this.btnIncorrecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncorrecto.BackgroundImage")));
            this.btnIncorrecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncorrecto.Location = new System.Drawing.Point(342, 239);
            this.btnIncorrecto.Name = "btnIncorrecto";
            this.btnIncorrecto.Size = new System.Drawing.Size(118, 31);
            this.btnIncorrecto.TabIndex = 11;
            this.btnIncorrecto.Text = "Siguiente";
            this.btnIncorrecto.UseVisualStyleBackColor = true;
            // 
            // btnIncorrecto3
            // 
            this.btnIncorrecto3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncorrecto3.BackgroundImage")));
            this.btnIncorrecto3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncorrecto3.Location = new System.Drawing.Point(342, 300);
            this.btnIncorrecto3.Name = "btnIncorrecto3";
            this.btnIncorrecto3.Size = new System.Drawing.Size(118, 31);
            this.btnIncorrecto3.TabIndex = 12;
            this.btnIncorrecto3.Text = "Siguiente";
            this.btnIncorrecto3.UseVisualStyleBackColor = true;
            // 
            // btnIncorecto2
            // 
            this.btnIncorecto2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncorecto2.BackgroundImage")));
            this.btnIncorecto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncorecto2.Location = new System.Drawing.Point(80, 300);
            this.btnIncorecto2.Name = "btnIncorecto2";
            this.btnIncorecto2.Size = new System.Drawing.Size(118, 31);
            this.btnIncorecto2.TabIndex = 13;
            this.btnIncorecto2.Text = "Siguiente";
            this.btnIncorecto2.UseVisualStyleBackColor = true;
            // 
            // Fase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 352);
            this.Controls.Add(this.btnIncorecto2);
            this.Controls.Add(this.btnIncorrecto3);
            this.Controls.Add(this.btnIncorrecto);
            this.Controls.Add(this.btnCorrecto);
            this.Controls.Add(this.labPregunta);
            this.Name = "Fase2";
            this.Text = "Fase2";
            this.Load += new System.EventHandler(this.Fase2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPregunta;
        private System.Windows.Forms.Button btnCorrecto;
        private System.Windows.Forms.Button btnIncorrecto;
        private System.Windows.Forms.Button btnIncorrecto3;
        private System.Windows.Forms.Button btnIncorecto2;
    }
}