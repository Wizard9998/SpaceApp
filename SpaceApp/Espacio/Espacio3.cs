using SpaceApp.Marte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceApp.Espacio
{
    public partial class Espacio3 : Form
    {
        public Espacio3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Espacio3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb4.Checked == true)
            {

                pictureBox1.Location = new Point(800, 100);
                MessageBox.Show("Perfecto , haz acertado la respuesta");
                Marte1 m = new Marte1();
                m.Show();
                this.Close();
            }
            else MessageBox.Show("Respuesta incorrecta , vuelve a intentarlo");
        }
    }
}
