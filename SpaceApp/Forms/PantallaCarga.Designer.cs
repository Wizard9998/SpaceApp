
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
            this.lblDato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(368, 326);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(38, 15);
            this.lblDato.TabIndex = 0;
            this.lblDato.Text = "label1";
            // 
            // PantallaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDato);
            this.Name = "PantallaCarga";
            this.Text = "PantallaCarga";
            this.Load += new System.EventHandler(this.PantallaCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato;
    }
}