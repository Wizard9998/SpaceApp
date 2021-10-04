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
            if (radioButton4.Checked == true)
            {

                pictureBox1.Location = new Point(800, 100);
                MessageBox.Show("Perfect, you got the answer right !!");
                Marte1 m = new Marte1();
                m.Show();
                this.Close();
            }
            else MessageBox.Show("Wrong answer, try again");
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
