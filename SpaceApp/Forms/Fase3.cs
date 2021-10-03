using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceApp.Forms
{
    public partial class Fase3 : Form
    {
        public Fase3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                pictureBox1.Visible = (true);
                MessageBox.Show("Perfecto , haz acertado la respuesta");
                
                this.Close();
            }
            else MessageBox.Show("Respuesta incorrecta , vuelve a intentarlo");
        }

        private void Fase3_Load(object sender, EventArgs e)
        {

        }
    }
}
