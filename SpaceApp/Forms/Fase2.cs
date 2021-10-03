using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceApp.Forms
{
    public partial class Fase2 : Form
    {
        
        public Fase2()
        {
            InitializeComponent();
        }

        private void Fase2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox3.Visible = (true);
                MessageBox.Show("Perfecto , haz acertado la respuesta");
                Fase3 f = new Fase3();
                f.Show();
                this.Close();
            }
            else MessageBox.Show("Respuesta incorrecta , vuelve a intentarlo");
        }
    }
}
