using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceApp.Espacio
{
    public partial class espacio1 : Form
    {
        public espacio1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void espacio1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdbRespuestaEspacio1.Checked == true)
            {

                pictureBox1.Location = new Point(200,100);
                MessageBox.Show("Perfect, you got the answer right !!");
                Espacio2 es = new Espacio2();
                es.Show();
                this.Close();
            }
            else MessageBox.Show("Wrong answer, try again");
        }
    }
}
