using SpaceApp.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceApp.Forms
{
    public partial class Seleccion : Form
    {
        Fachada fachada;

        public Seleccion(Fachada unafachada)

        {
           
            this.fachada = unafachada;
            InitializeComponent();
          
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string UnNombre = txtNombre.Text;
            string UnApellido = txtApellido.Text;
            int UnaEdad = Convert.ToInt32(txtEdad.Text);

            fachada.agregarAstronauta(UnNombre, UnApellido, UnaEdad);

        }

        private void lblAstronautas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            PantallaCarga p = new PantallaCarga();
            p.Show();
            this.Close();


        }
    }
}
