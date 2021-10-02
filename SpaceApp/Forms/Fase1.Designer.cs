
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
            this.btnResp1 = new System.Windows.Forms.Button();
            this.btnResp2 = new System.Windows.Forms.Button();
            this.btnResp3 = new System.Windows.Forms.Button();
            this.btnResp4 = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.lbPregunta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResp1
            // 
            this.btnResp1.Location = new System.Drawing.Point(126, 299);
            this.btnResp1.Name = "btnResp1";
            this.btnResp1.Size = new System.Drawing.Size(75, 23);
            this.btnResp1.TabIndex = 0;
            this.btnResp1.Text = "button1";
            this.btnResp1.UseVisualStyleBackColor = true;
            this.btnResp1.Click += new System.EventHandler(this.btnResp1_Click);
            // 
            // btnResp2
            // 
            this.btnResp2.Location = new System.Drawing.Point(560, 298);
            this.btnResp2.Name = "btnResp2";
            this.btnResp2.Size = new System.Drawing.Size(75, 23);
            this.btnResp2.TabIndex = 1;
            this.btnResp2.Text = "button2";
            this.btnResp2.UseVisualStyleBackColor = true;
            // 
            // btnResp3
            // 
            this.btnResp3.Location = new System.Drawing.Point(126, 364);
            this.btnResp3.Name = "btnResp3";
            this.btnResp3.Size = new System.Drawing.Size(75, 23);
            this.btnResp3.TabIndex = 2;
            this.btnResp3.Text = "button3";
            this.btnResp3.UseVisualStyleBackColor = true;
            // 
            // btnResp4
            // 
            this.btnResp4.Location = new System.Drawing.Point(560, 364);
            this.btnResp4.Name = "btnResp4";
            this.btnResp4.Size = new System.Drawing.Size(75, 23);
            this.btnResp4.TabIndex = 3;
            this.btnResp4.Text = "button4";
            this.btnResp4.UseVisualStyleBackColor = true;
            // 
            // imgBox
            // 
            this.imgBox.Image = ((System.Drawing.Image)(resources.GetObject("imgBox.Image")));
            this.imgBox.Location = new System.Drawing.Point(326, 102);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(125, 191);
            this.imgBox.TabIndex = 4;
            this.imgBox.TabStop = false;
            // 
            // lbPregunta
            // 
            this.lbPregunta.AutoSize = true;
            this.lbPregunta.Location = new System.Drawing.Point(314, 37);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(55, 15);
            this.lbPregunta.TabIndex = 5;
            this.lbPregunta.Text = "Pregunta";
            // 
            // Fase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPregunta);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.btnResp4);
            this.Controls.Add(this.btnResp3);
            this.Controls.Add(this.btnResp2);
            this.Controls.Add(this.btnResp1);
            this.Name = "Fase1";
            this.Text = "Fase1";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResp1;
        private System.Windows.Forms.Button btnResp2;
        private System.Windows.Forms.Button btnResp3;
        private System.Windows.Forms.Button btnResp4;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label lbPregunta;
    }
}