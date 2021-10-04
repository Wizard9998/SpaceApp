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
                MessageBox.Show("Perfect, you got the answer right !!");
                Espacio3 ep = new Espacio3();
                ep.Show();
                this.Close();
            }
            else MessageBox.Show("Wrong answer, try again");
        }

        private void rdbRespuestaX1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
