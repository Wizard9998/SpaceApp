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
        Fachada fachadas;

        public Seleccion(Fachada unaFachada)
        {
            this.fachadas = unaFachada;
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
            fachadas.agregarAstronauta(UnNombre, UnApellido, UnaEdad);
            lblAstronautas.Items.Add(UnNombre);
            lblAstronautas.Items.Add(UnApellido);
            lblAstronautas.Items.Add(UnaEdad);

        }

        private void lblAstronautas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
