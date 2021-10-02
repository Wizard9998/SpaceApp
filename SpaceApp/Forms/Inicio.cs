
using SpaceApp.clases;
using SpaceApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceApp
{
    public partial class FormInicio : Form
    {
        Fachada fachada;
        public FormInicio(Fachada unafachada)

        {
            this.fachada = unafachada;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Seleccion s = new Seleccion(fachada);
            s.Show();this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
