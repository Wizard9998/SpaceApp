using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceApp.Espacio
{
    public partial class Espacio2 : Form
    {
        public Espacio2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbRespuestaX2.Checked == true)
            {

                pictureBox1.Location = new Point(450, 100);
                MessageBox.Show("Perfecto , haz acertado la respuesta");
                Espacio3 ep = new Espacio3();
                ep.Show();
                this.Close();
            }
            else MessageBox.Show("Respuesta incorrecta , vuelve a intentarlo");
        }
    }
}
