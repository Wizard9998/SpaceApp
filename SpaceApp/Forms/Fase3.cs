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
                MessageBox.Show("Perfect, you got the answer right !!");
                Espacio.espacio1 esp = new Espacio.espacio1();
                esp.Show();
                this.Close();
            }
            else MessageBox.Show("Wrong answer, try again");
        }

        private void Fase3_Load(object sender, EventArgs e)
        {

        }
    }
}
